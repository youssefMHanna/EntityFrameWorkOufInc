using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OufInc
{
    public partial class InvoiceForm : Form
    {
        bool IO;
        EF_ADO localDB;
        ItemWVal[] TraderSelectorItems;
        ItemWVal[] WarehouseSelectorItems;
        DataTable dataTable;

        public InvoiceForm()
        {
            InitializeComponent();
        }
        public InvoiceForm(bool InOut) : this()
        {
            IO = InOut;

            if (InOut)
                this.Text = "Export Permit";
            else
                this.Text = "Import Permit";

            localDB = new EF_ADO();
            WarehouseSelectorItems = localDB.Warehouses.Select(a => new ItemWVal { Text = a.Warehouse_Name, Value = a.Warehouse_ID }).ToArray();
            WarehouseSelector.Items.AddRange(WarehouseSelectorItems);
            TraderSelectorItems = localDB.Traders.Select(a => new ItemWVal { Text = a.Name, Value = a.Trader_ID }).ToArray();
            TraderSelector.Items.AddRange(TraderSelectorItems);

            dataTable = new DataTable();
            var keyCode = new DataColumn("Code");
            dataTable.Columns.Add(keyCode);
            dataTable.Columns.Add(new DataColumn("Number"));
            if (!InOut)
            {
                dataTable.Columns.Add(new DataColumn("Production_Date"));
                dataTable.Columns.Add(new DataColumn("Valid_Date"));
            }
            dataTable.PrimaryKey = new DataColumn[1] { keyCode };
            dataGridView1.DataSource = dataTable;
            updateSelector();
        }

        private void updateSelector()
        {
            localDB = new EF_ADO();
            if (InvoiceSelector.Items.Count > 0)
                InvoiceSelector.Items.Clear();
            InvoiceSelector.Items.AddRange(localDB.Invoices.Where(a => a.In_Out == IO).Select(a => a.Invoice_ID.ToString()).ToArray());
        }
        private void InvoiceSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            localDB = new EF_ADO();
            Invoice invoice = localDB.Invoices.Find(int.Parse(InvoiceSelector.SelectedItem.ToString()));
            WarehouseSelector.SelectedItem = WarehouseSelectorItems.Where(a => a.Value == invoice.Warehouse_ID).First();
            TraderSelector.SelectedItem = TraderSelectorItems.Where(a => a.Value == invoice.Trader_ID).First();
            dateTimePicker1.Value = invoice.Invoice_Date;
            dataTable.Rows.Clear();
            foreach (var tuple in invoice.Invoice_Items)
            {
                DataRow drToAdd = dataTable.NewRow();
                drToAdd["Code"] = tuple.Code;
                drToAdd["Number"] = tuple.Number;
                if (!IO)
                {
                    drToAdd["Production_Date"] = tuple.Production_Date;
                    drToAdd["Valid_Date"] = tuple.Valid_Date;
                }
                dataTable.Rows.Add(drToAdd);
            }
            dataTable.AcceptChanges();
            dataGridView1.DataSource = dataTable;
        }
        void addInvoice()
        {
            localDB = new EF_ADO();
            Invoice invoice = new Invoice();
            invoice.In_Out = IO;
            invoice.Trader_ID = ((ItemWVal)(TraderSelector.SelectedItem)).Value;
            invoice.Warehouse_ID = ((ItemWVal)(WarehouseSelector.SelectedItem)).Value;
            invoice.Invoice_Date = dateTimePicker1.Value;
            foreach (DataRow row in dataTable.Rows)
            {
                Invoice_Items invoice_Items = new Invoice_Items();
                invoice_Items.Invoice_ID = invoice.Invoice_ID;
                invoice_Items.Code = int.Parse(row["Code"].ToString());
                invoice_Items.Number = int.Parse(row["Number"].ToString());
                if (!IO)
                {
                    invoice_Items.Production_Date = DateTime.Parse(row["Production_Date"].ToString());
                    invoice_Items.Valid_Date = DateTime.Parse(row["Valid_Date"].ToString());
                }
                invoice.Invoice_Items.Add(invoice_Items);
            }
            localDB.Invoices.Add(invoice);

            bool acceptableChange;
            localDB.Warehouses.Find(invoice.Warehouse_ID).WarehouseReport(out acceptableChange);
            if(acceptableChange)
            {
                localDB.trySaveChanges();
                updateSelector();
                InvoiceSelector.SelectedItem = invoice.Invoice_ID.ToString();
            }
            else
            {
                localDB = new EF_ADO();
                MessageBox.Show("Unacceptable Change");
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            addInvoice();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            localDB = new EF_ADO();
            Invoice invoice = localDB.Invoices.Find(int.Parse(InvoiceSelector.SelectedItem.ToString()));
            invoice.Trader_ID = ((ItemWVal)(TraderSelector.SelectedItem)).Value;
            invoice.Warehouse_ID = ((ItemWVal)(WarehouseSelector.SelectedItem)).Value;
            invoice.Invoice_Date = dateTimePicker1.Value;
            invoice.Invoice_Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                Invoice_Items invoice_Items = new Invoice_Items();
                invoice_Items.Invoice_ID = invoice.Invoice_ID;
                invoice_Items.Code = int.Parse(row["Code"].ToString());
                invoice_Items.Number = int.Parse(row["Number"].ToString());
                if (!IO)
                {
                    invoice_Items.Production_Date = DateTime.Parse(row["Production_Date"].ToString());
                    invoice_Items.Valid_Date = DateTime.Parse(row["Valid_Date"].ToString());
                }
                invoice.Invoice_Items.Add(invoice_Items);
            }
            bool acceptableChange;
            localDB.Warehouses.Find(invoice.Warehouse_ID).WarehouseReport(out acceptableChange);
            if (acceptableChange)
            {
                localDB.trySaveChanges();
            }
            else
            {
                localDB = new EF_ADO();
                MessageBox.Show("Unacceptable Change");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemPicker itemPicker;
            DataRow dataRow;

            if (e.RowIndex >= dataTable.Rows.Count)
            {
                itemPicker = new ItemPicker(IO, dataTable);
                itemPicker.ShowDialog();

                if (itemPicker.DialogResult == DialogResult.OK)
                {
                    if (dataTable.Rows.Contains(((ItemWVal)(itemPicker.ItemSelector.SelectedItem)).Value))
                    {
                        dataRow = dataTable.Rows.Find(((ItemWVal)(itemPicker.ItemSelector.SelectedItem)).Value);
                        dataRow["Code"] = ((ItemWVal)(itemPicker.ItemSelector.SelectedItem)).Value;
                        dataRow["Number"] = int.Parse(itemPicker.QuantityTextBox.Text);
                        if (!IO)
                        {
                            dataRow["Production_Date"] = itemPicker.productionDateTimePicker.Value;
                            dataRow["Valid_Date"] = itemPicker.ValidDateTimePicker.Value;
                        }
                    }
                    else
                    {
                        dataRow = dataTable.NewRow();
                        dataRow["Code"] = ((ItemWVal)(itemPicker.ItemSelector.SelectedItem)).Value;
                        dataRow["Number"] = int.Parse(itemPicker.QuantityTextBox.Text);
                        if (!IO)
                        {
                            dataRow["Production_Date"] = itemPicker.productionDateTimePicker.Value;
                            dataRow["Valid_Date"] = itemPicker.ValidDateTimePicker.Value;
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }

            }
            else if (e.RowIndex >= 0)
            {

                itemPicker = new ItemPicker(IO, dataTable, int.Parse(dataTable.Rows[e.RowIndex]["Code"].ToString()));
                itemPicker.ShowDialog();



                if (itemPicker.DialogResult == DialogResult.OK)
                {
                    dataRow = dataTable.Rows[e.RowIndex];
                    dataRow["Number"] = int.Parse(itemPicker.QuantityTextBox.Text);
                    if (!IO)
                    {
                        dataRow["Production_Date"] = itemPicker.productionDateTimePicker.Value;
                        dataRow["Valid_Date"] = itemPicker.ValidDateTimePicker.Value;
                    }

                }
            }
            else
                return;

        }
    }
}
