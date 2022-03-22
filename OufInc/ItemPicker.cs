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
    public partial class ItemPicker : Form
    {
        bool io;
        bool IsInvoiceVsTransfer = false;
        public DataTable dataTable;
        public int SelectedItem;
        EF_ADO localDB;
        ItemWVal[] ItemSelectorItems;

        public ItemPicker(  )
        {
            InitializeComponent();
        }
        public ItemPicker(bool? io, DataTable dataTable) : this()
        {
            this.dataTable = dataTable;
            if ( io.HasValue)
            {
                IsInvoiceVsTransfer = true;
                if( io.Value )
                {
                    this.io = io.Value;
                    ValidDateTimePicker.Visible = false;
                    productionDateTimePicker.Visible = false;
                    label4.Visible = false;
                    label3.Visible = false;

                }
            }
            localDB = new EF_ADO();
            ItemSelectorItems = localDB.Goods.Select(a => new ItemWVal { Text = a.Goods_Name, Value = a.Code }).ToArray();
            ItemSelector.Items.AddRange(ItemSelectorItems);
        }
        public ItemPicker( bool? io, DataTable dataTable, int SelectedItem ) :this(io , dataTable)
        {
            this.SelectedItem = SelectedItem;
            ItemSelector.SelectedItem = ItemSelectorItems.Where(a => a.Value == SelectedItem).First();
            ItemSelector.Enabled = false;

            DataRow row = dataTable.Rows.Find(SelectedItem);

            QuantityTextBox.Text = row["Number"].ToString();
            if (!this.io)
            {
                ValidDateTimePicker.Value = DateTime.Parse(row["Production_Date"].ToString());
                productionDateTimePicker.Value = DateTime.Parse(row["Valid_Date"].ToString());
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
            this.Close();
        }

        private void ItemSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = ((ItemWVal)ItemSelector.SelectedItem).Value;

            DataRow row = dataTable.Rows.Find(SelectedItem);

            if(row != null)
            {
                QuantityTextBox.Text = row["Number"].ToString();
                if(!io)
                {
                    ValidDateTimePicker.Value = DateTime.Parse(row["Production_Date"].ToString());
                    productionDateTimePicker.Value = DateTime.Parse(row["Valid_Date"].ToString());
                }
            }
        }
    }
}
