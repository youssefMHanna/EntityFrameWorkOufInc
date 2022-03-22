using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OufInc
{
    public partial class WarehouseForm : System.Windows.Forms.Form
    {
        EF_ADO localDB;

        public WarehouseForm()
        {
            InitializeComponent();
            localDB = new EF_ADO();
            updateSelector();
        }
        private void updateSelector()
        {
            
            if (WarehouseSelector.Items.Count > 0)
                WarehouseSelector.Items.Clear();
            WarehouseSelector.Items.AddRange(localDB.Warehouses.Select(a => a.Warehouse_ID.ToString()).ToArray());
        }
        private void WarehouseSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            localDB = new EF_ADO();
            Warehouse warehouse = localDB.Warehouses.Find(int.Parse(WarehouseSelector.SelectedItem.ToString()));
            NameTextBox.Text = warehouse.Warehouse_Name;
            AddressTextBox.Text = warehouse.Warehouse_Address;
            ManagerTextBox.Text = warehouse.Manager;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            localDB = new EF_ADO();
            Warehouse warehouse = localDB.Warehouses.Find(int.Parse(WarehouseSelector.SelectedItem.ToString()));
            warehouse.Warehouse_Name = NameTextBox.Text;
            warehouse.Warehouse_Address = AddressTextBox.Text;
            warehouse.Manager = ManagerTextBox.Text;
            localDB.trySaveChanges();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            localDB = new EF_ADO();
            Warehouse warehouse = new Warehouse();
            warehouse.Warehouse_Name = NameTextBox.Text;
            warehouse.Warehouse_Address = AddressTextBox.Text;
            warehouse.Manager = ManagerTextBox.Text;
            localDB.Warehouses.Add(warehouse);
            localDB.trySaveChanges();
            updateSelector();
        }
    }
}
