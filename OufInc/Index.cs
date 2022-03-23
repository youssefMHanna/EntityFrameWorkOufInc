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
    public partial class Index : System.Windows.Forms.Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void TraderButton_Click(object sender, EventArgs e)
        {
            TraderForm traderForm = new TraderForm();
            traderForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WarehouseForm warehouseForm = new WarehouseForm();
            warehouseForm.ShowDialog();
        }

        private void GoodsButton_Click(object sender, EventArgs e)
        {
            GoodsForm goodsForm = new GoodsForm();
            goodsForm.ShowDialog();
        }

        private void InPermitButton_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceForm = new InvoiceForm(false);
            invoiceForm.ShowDialog();
        }

        private void OutPermitButton_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceForm = new InvoiceForm(true);
            invoiceForm.ShowDialog();
        }

        private void TransferPermitButton_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm();
            transferForm.ShowDialog();
        }

        private void WarehouseReport_Click(object sender, EventArgs e)
        {
            WarehouseReportForm warehouseReportForm = new WarehouseReportForm();
            warehouseReportForm.ShowDialog();
        }
    }
}
