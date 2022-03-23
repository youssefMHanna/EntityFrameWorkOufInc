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
    public partial class ItemMovementReportForm : Form
    {
        EF_ADO localDB = new EF_ADO();
        DataTable dataTable;

        public ItemMovementReportForm()
        {
            InitializeComponent();
            dataTable = new DataTable();

            dataTable.Columns.Add(new DataColumn("Name"));
            dataTable.Columns.Add(new DataColumn("Description"));
            dataTable.Columns.Add(new DataColumn("Number"));
            dataTable.Columns.Add(new DataColumn("Production_Date"));
            dataTable.Columns.Add(new DataColumn("Valid_Date"));

            dataGridView1.DataSource = dataTable;
            WarehouseSelector.Items.AddRange( localDB.Warehouses.Select(a => new ItemWVal { Text = a.Warehouse_Name, Value = a.Warehouse_ID }).ToArray());
        }

        void updateView()
        {

            dataTable.Rows.Clear();
            List<Invoice_transfer_Items> ts = new List<Invoice_transfer_Items>();
            foreach (var w in WarehouseSelector.SelectedItems)
            { 
                ts.AddRange( localDB.Warehouses.Find(((ItemWVal)w).Value).WarehouseReport(dateTimePicker1.Value));
            }
            ts = ts.Distinct().ToList();

            var temp = localDB.Goods.ToList().Where(a => ts.Select(a1=>a1.Code).Contains( a.Code ) ).SelectMany(a=>a.ItemUpToDateReport(dateTimePicker1.Value)).Distinct();
            foreach (var item in temp)
            {
                DataRow drToAdd = dataTable.NewRow();

                drToAdd["Name"] = item.Item1;
                drToAdd["Description"] = item.Item2;
                drToAdd["Number"] = item.Item3;
                drToAdd["Production_Date"] = item.Item4;
                drToAdd["Valid_Date"] = item.Item5;
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
