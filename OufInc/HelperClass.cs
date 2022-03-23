using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OufInc
{
    static class HelperClass
    {
        public static void seeException (this DbEntityValidationException ev )
        {
            foreach (var eve in ev.EntityValidationErrors)
            {
                MessageBox.Show($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation errors:");
                foreach (var ve in eve.ValidationErrors)
                {
                    MessageBox.Show($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                }
            }
        }
        public static void trySaveChanges (this EF_ADO localDB)
        {
            try
            {
                localDB.SaveChanges();
            }
            catch (DbEntityValidationException eve)
            {
                eve.seeException();
            }
        }
        public static void AddItems(this List<Invoice_transfer_Items> invoice_Items, List<Invoice_transfer_Items> itemsToAdd)
        {
            foreach (var item in itemsToAdd)
            {
                if (!invoice_Items.Contains(item, new ItemEqualityDateComparator()))
                {
                    Invoice_transfer_Items _temp = new Invoice_Items() 
                    { 
                        Code = item.Code ,
                        Number = item.Number , 
                        Production_Date = item.Production_Date , 
                        Valid_Date = item.Valid_Date 
                    };
                    invoice_Items.Add(_temp);
                }
                else
                {
                    invoice_Items.Find(a => a.Code == item.Code && a.Production_Date == item.Production_Date).Number += item.Number;
                }
            }
        }
        public static bool SubtractItems(this List<Invoice_transfer_Items> invoice_Items, List<Invoice_transfer_Items> itemsToSub)
        {
            foreach (var item in itemsToSub)
            {
                int n = item.Number;
                invoice_Items.Where(a => a.Code == item.Code).OrderBy(a=>a.Production_Date).ToList().ForEach( a=>
                {
                    if (a.Number > n)
                    {
                        a.Number-=n;
                        n=0;
                    }
                    else
                    {
                        n-=a.Number;
                        invoice_Items.Remove(a);
                    }
                });
                if (n > 0)
                    return false;
            }
            return true;
        }

        public static List<Invoice_transfer_Items> WarehouseReport(this Warehouse warehouse,out bool res) 
        {
            res = true;
            List<Invoice_transfer_Items> _Items = new List<Invoice_transfer_Items>();
            _Items.AddItems(warehouse.Invoices.Where(a => !a.In_Out).SelectMany(a => a.Invoice_Items).ToList().Select(a => (Invoice_transfer_Items)a).ToList());
            res&=_Items.SubtractItems(warehouse.Invoices.Where(a => a.In_Out).SelectMany(a => a.Invoice_Items).ToList().Select(a => (Invoice_transfer_Items)a).ToList());
            _Items.AddItems(warehouse.ToTransfers.SelectMany(a=>a.Transefer_Items).ToList().Select(a => (Invoice_transfer_Items)a).ToList());
            res &=_Items.SubtractItems(warehouse.FromTransfers.SelectMany(a => a.Transefer_Items).ToList().Select(a => (Invoice_transfer_Items)a).ToList());
            return _Items;
        }
        public static List<Invoice_transfer_Items> WarehouseReport(this Warehouse warehouse) { bool _Dummy; return warehouse.WarehouseReport(out _Dummy); }
        public static List<Invoice_transfer_Items> WarehouseUpToDateReport(this Warehouse warehouse, DateTime date)
        {
           
            List<Invoice_transfer_Items> _Items = new List<Invoice_transfer_Items>();
            _Items.AddItems(warehouse.Invoices.Where(a => !a.In_Out  && a.Invoice_Date <= date).SelectMany(a => a.Invoice_Items).ToList().Select(a => (Invoice_transfer_Items)a).ToList());
            _Items.SubtractItems(warehouse.Invoices.Where(a => a.In_Out && a.Invoice_Date <= date).SelectMany(a => a.Invoice_Items).ToList().Select(a => (Invoice_transfer_Items)a).ToList());
            _Items.AddItems(warehouse.ToTransfers.Where(a => a.Transfer_Date <= date ).SelectMany(a => a.Transefer_Items ).ToList().Select(a => (Invoice_transfer_Items)a).ToList());
            _Items.SubtractItems(warehouse.FromTransfers.Where(a => a.Transfer_Date <= date).SelectMany(a => a.Transefer_Items).ToList().Select(a => (Invoice_transfer_Items)a).ToList());
            return _Items;
        }
        public static List<(IInvoice_Transfer, int, DateTime?, DateTime?)> ItemUpToDateReport(this Good good, DateTime date)
        {
            List<(IInvoice_Transfer, int, DateTime?, DateTime?)> ls = new List<(IInvoice_Transfer, int, DateTime?, DateTime?)>();
            ls.AddRange(good.Invoice_Items.Where(a=>a.Invoice.Invoice_Date <= date).Select(a => ((IInvoice_Transfer)a.Invoice, a.Number, a.Production_Date, a.Valid_Date)).ToList());
            ls.AddRange(good.Transefer_Items.Where(a => a.Transfer.Transfer_Date <= date).Select(a => ((IInvoice_Transfer)a.Transfer, a.Number, a.Production_Date, a.Valid_Date)).ToList());
            return ls;
        }
        public static List<IInvoice_Transfer> WarehousePermitsUpToDateReport(this Warehouse warehouse, DateTime date)
        {
            List<IInvoice_Transfer> ls = new List<IInvoice_Transfer>();
            ls.AddRange(warehouse.Invoices.Where(a=>a.Invoice_Date<=date).ToList());
            ls.AddRange(warehouse.FromTransfers.Where(a=>a.Transfer_Date<=date).ToList());
            ls.AddRange(warehouse.ToTransfers.Where(a => a.Transfer_Date <= date).ToList());
            return ls;
        }
        public static List<Invoice_transfer_Items> WarehouseDatedItemsReport(this Warehouse warehouse, DateTime date)
        {
            var _Items = warehouse.WarehouseUpToDateReport(date);
            _Items.SubtractItems(warehouse.Invoices.Where(a => a.In_Out && a.Invoice_Date > date).SelectMany(a => a.Invoice_Items).ToList().Select(a => (Invoice_transfer_Items)a).ToList());
            _Items.SubtractItems(warehouse.FromTransfers.Where(a => a.Transfer_Date > date).SelectMany(a => a.Transefer_Items).ToList().Select(a => (Invoice_transfer_Items)a).ToList());
            return _Items;
        }
        public static List<Invoice_transfer_Items> WarehouseAboutToExpireItemsReport(this Warehouse warehouse, DateTime date)
        {
            List<Invoice_transfer_Items> _Items = new List<Invoice_transfer_Items>();
            _Items = warehouse.WarehouseReport();
            _Items.Select(a => a.Valid_Date < date);
            return _Items;
        }

    }
}
