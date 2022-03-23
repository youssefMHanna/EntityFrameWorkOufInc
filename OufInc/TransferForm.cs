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
    public partial class TransferForm : Form
    {

        EF_ADO localDB;
        ItemWVal[] TraderSelectorItems;
        ItemWVal[] WarehouseSelectorItems;
        DataTable dataTable;
        public TransferForm()
        {
            InitializeComponent();
            localDB = new EF_ADO();
            WarehouseSelectorItems = localDB.Warehouses.Select(a => new ItemWVal { Text = a.Warehouse_Name, Value = a.Warehouse_ID }).ToArray();
            WarehouseToSelector.Items.AddRange(WarehouseSelectorItems);
            WarehouseFromSelector.Items.AddRange(WarehouseSelectorItems);
            TraderSelectorItems = localDB.Traders.Select(a => new ItemWVal { Text = a.Name, Value = a.Trader_ID }).ToArray();
            TraderSelector.Items.AddRange(TraderSelectorItems);

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
            localDB = new EF_ADO();
            if (TransferSelector.Items.Count > 0)
                TransferSelector.Items.Clear();
            TransferSelector.Items.AddRange(localDB.Transfers.Select(a => a.Transfer_ID.ToString()).ToArray());
        }

        private void InvoiceSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            localDB = new EF_ADO();
            Transfer transfer = localDB.Transfers.Find(int.Parse(TransferSelector.SelectedItem.ToString()));
            WarehouseFromSelector.SelectedItem = WarehouseSelectorItems.Where(a => a.Value == transfer.FromWarehouse_ID).First();
            WarehouseToSelector.SelectedItem = WarehouseSelectorItems.Where(a => a.Value == transfer.ToWarehouse_ID).First();
            TraderSelector.SelectedItem = TraderSelectorItems.Where(a => a.Value == transfer.Trader_ID).First();
            dateTimePicker1.Value = transfer.Transfer_Date;
            dataTable.Rows.Clear();
            foreach (var tuple in transfer.Transefer_Items)
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
        void addTransfer()
        {
            localDB = new EF_ADO();
            Transfer transfer = new Transfer();
            transfer.Trader_ID = ((ItemWVal)(TraderSelector.SelectedItem)).Value;
            transfer.FromWarehouse_ID = ((ItemWVal)(WarehouseFromSelector.SelectedItem)).Value;
            transfer.ToWarehouse_ID = ((ItemWVal)(WarehouseToSelector.SelectedItem)).Value;
            transfer.Transfer_Date = dateTimePicker1.Value;
            foreach (DataRow row in dataTable.Rows)
            {
                Transefer_Items transferItems = new Transefer_Items();
                transferItems.Transfer_ID = transfer.Transfer_ID;
                transferItems.Code = int.Parse(row["Code"].ToString());
                transferItems.Number = int.Parse(row["Number"].ToString());
                transferItems.Production_Date = DateTime.Parse(row["Production_Date"].ToString());
                transferItems.Valid_Date = DateTime.Parse(row["Valid_Date"].ToString());
                transfer.Transefer_Items.Add(transferItems);
            }
            localDB.Transfers.Add(transfer);

            
            bool acceptableChange;
            localDB.Warehouses.Find(transfer.FromWarehouse_ID ).WarehouseReport(out acceptableChange);
            if (acceptableChange)
            {
                localDB.trySaveChanges();
                updateSelector();
                TransferSelector.SelectedItem = transfer.Transfer_ID.ToString();
            }
            else
            {
                localDB = new EF_ADO();
                MessageBox.Show("Unacceptable Change");
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            addTransfer();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            localDB = new EF_ADO();
            Transfer transfer = localDB.Transfers.Find(int.Parse(TransferSelector.SelectedItem.ToString()));
            transfer.Trader_ID = ((ItemWVal)(TraderSelector.SelectedItem)).Value;
            transfer.FromWarehouse_ID = ((ItemWVal)(WarehouseFromSelector.SelectedItem)).Value;
            transfer.ToWarehouse_ID = ((ItemWVal)(WarehouseToSelector.SelectedItem)).Value;
            transfer.Transfer_Date = dateTimePicker1.Value;
            transfer.Transefer_Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                Transefer_Items transferItems = new Transefer_Items();
                transferItems.Transfer_ID = transfer.Transfer_ID;
                transferItems.Code = int.Parse(row["Code"].ToString());
                transferItems.Number = int.Parse(row["Number"].ToString());
                transferItems.Production_Date = DateTime.Parse(row["Production_Date"].ToString());
                transferItems.Valid_Date = DateTime.Parse(row["Valid_Date"].ToString());
                transfer.Transefer_Items.Add(transferItems);
            }
            bool acceptableChange;
            localDB.Warehouses.Find(transfer.FromWarehouse_ID).WarehouseReport(out acceptableChange);
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
                itemPicker = new ItemPicker(null, dataTable);
                itemPicker.ShowDialog();

                if (itemPicker.DialogResult == DialogResult.OK)
                {
                    if (dataTable.Rows.Contains(((ItemWVal)(itemPicker.ItemSelector.SelectedItem)).Value))
                    {
                        dataRow = dataTable.Rows.Find(((ItemWVal)(itemPicker.ItemSelector.SelectedItem)).Value);
                        dataRow["Code"] = ((ItemWVal)(itemPicker.ItemSelector.SelectedItem)).Value;
                        dataRow["Number"] = int.Parse(itemPicker.QuantityTextBox.Text);
                        dataRow["Valid_Date"] = itemPicker.ValidDateTimePicker.Value;
                        dataRow["Production_Date"] = itemPicker.productionDateTimePicker.Value;
                    }
                    else
                    {
                        dataRow = dataTable.NewRow();
                        dataRow["Code"] = ((ItemWVal)(itemPicker.ItemSelector.SelectedItem)).Value;
                        dataRow["Number"] = int.Parse(itemPicker.QuantityTextBox.Text);
                        dataRow["Valid_Date"] = itemPicker.ValidDateTimePicker.Value;
                        dataRow["Production_Date"] = itemPicker.productionDateTimePicker.Value;
                        dataTable.Rows.Add(dataRow);
                    }
                }
            }
            else if (e.RowIndex >= 0)
            {
                itemPicker = new ItemPicker(null, dataTable,int.Parse( dataTable.Rows[e.RowIndex]["Code"].ToString() ) );
                itemPicker.ShowDialog();

                if (itemPicker.DialogResult == DialogResult.OK)
                {
                    dataRow = dataTable.Rows[e.RowIndex];
                    //dataRow = dataTable.Rows.Find(((ItemWVal)(itemPicker.ItemSelector.SelectedItem)).Value);
                    dataRow["Code"] = ((ItemWVal)(itemPicker.ItemSelector.SelectedItem)).Value;
                    dataRow["Number"] = int.Parse(itemPicker.QuantityTextBox.Text);
                    dataRow["Valid_Date"] = itemPicker.ValidDateTimePicker.Value;
                    dataRow["Production_Date"] = itemPicker.productionDateTimePicker.Value;
                }
            }
            else
                return;
        }

    }
}
