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
                    invoice_Items.Add(item);
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
                }) ;

                if (n > 0)
                    return false;
            }
            
            return true;
        }

    }
}
