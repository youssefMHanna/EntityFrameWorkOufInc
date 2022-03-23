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
    public partial class WarehouseReportForm : Form
    {
        EF_ADO localDB;
        ItemWVal[] WarehouseSelectorItems;
        DataTable dataTable;
        Warehouse warehouse;
        public WarehouseReportForm()
        {
            InitializeComponent();

            localDB = new EF_ADO();
            dataTable = new DataTable();
            var keyCode = new DataColumn("Code");
            dataTable.Columns.Add(keyCode);
            dataTable.Columns.Add(new DataColumn("Number"));
            dataTable.Columns.Add(new DataColumn("Production_Date"));
            dataTable.Columns.Add(new DataColumn("Valid_Date"));
            dataTable.PrimaryKey = new DataColumn[1] { keyCode };
            dataGridView1.DataSource = dataTable;
            updateSelector();
        }

        private void updateSelector()
        {
            if (WarehouseSelector.Items.Count > 0)
                WarehouseSelector.Items.Clear();
            WarehouseSelectorItems = localDB.Warehouses.Select(a => new ItemWVal { Text = a.Warehouse_Name, Value = a.Warehouse_ID }).ToArray();
            WarehouseSelector.Items.AddRange(WarehouseSelectorItems);
        }

        private void WarehouseSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            var warehouseI = localDB.Warehouses.Find(((ItemWVal)WarehouseSelector.SelectedItem).Value).WarehouseReport();
            localDB = new EF_ADO();
            dataTable.Rows.Clear();
            foreach (var tuple in warehouseI)
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
    }
}
