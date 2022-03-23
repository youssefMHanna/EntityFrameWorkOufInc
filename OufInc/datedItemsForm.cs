using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OufInc
{
    public partial class DatedItemsForm : Form
    {

        EF_ADO localDB = new EF_ADO();
        DataTable dataTable;

        public DatedItemsForm()
        {
            InitializeComponent();

            dataTable = new DataTable();
            var keyCode = new DataColumn("Code");
            dataTable.Columns.Add(keyCode);
            dataTable.Columns.Add(new DataColumn("Number"));

            dataTable.Columns.Add(new DataColumn("Production_Date"));
            dataTable.Columns.Add(new DataColumn("Valid_Date"));

            dataTable.PrimaryKey = new DataColumn[1] { keyCode };
            dataGridView1.DataSource = dataTable;

            WarehouseSelector.Items.AddRange(localDB.Warehouses.Select(a => new ItemWVal { Text = a.Warehouse_Name, Value = a.Warehouse_ID }).ToArray());

        }

        void updateView()
        {

            dataTable.Rows.Clear();
            List<Invoice_transfer_Items> ts = new List<Invoice_transfer_Items>();
            foreach (var w in WarehouseSelector.SelectedItems)
            {
                ts.AddItems(localDB.Warehouses.Find(((ItemWVal)w).Value).WarehouseDatedItemsReport(dateTimePicker1.Value));
            }

            foreach (var tuple in ts)
            {
                DataRow drToAdd = dataTable.NewRow();
                drToAdd["Code"] = tuple.Code;
                drToAdd["Number"] = tuple.Number;
                drToAdd["Production_Date"] = tuple.Production_Date;
                drToAdd["Valid_Date"] = tuple.Valid_Date;
                dataTable.Rows.Add(drToAdd);
            }

            dataTable.AcceptChanges();
            dataGridView1.DataSource = dataTable;
        }
        private void WarehouseSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateView();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            updateView();
        }
    }
}
