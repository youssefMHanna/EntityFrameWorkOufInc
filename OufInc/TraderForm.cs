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
    public partial class TraderForm : System.Windows.Forms.Form
    {

        EF_ADO localDB;
        public TraderForm()
        {
            InitializeComponent();
            localDB = new EF_ADO();
            updateSelector();
        }

        private void updateSelector()
        {
            if(TraderSelector.Items.Count > 0)
                TraderSelector.Items.Clear();
            TraderSelector.Items.AddRange(localDB.Traders.Select(a => a.Trader_ID.ToString()).ToArray());
        }
        private void TraderSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            localDB = new EF_ADO();
            Trader trader = localDB.Traders.Find(int.Parse(TraderSelector.SelectedItem.ToString()));
            NameTextBox.Text = trader.Name;
            TelephoneTextBox.Text = trader.Telephone;
            FaxTextBox.Text = trader.Fax;
            MobileTextBox.Text = trader.Mobile;
            EmailTextBox.Text = trader.Email;
            WebsitTextBox.Text = trader.Website;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            localDB = new EF_ADO();
            Trader trader = localDB.Traders.Find(int.Parse(TraderSelector.SelectedItem.ToString()));
            trader.Name = NameTextBox.Text;
            trader.Telephone = TelephoneTextBox.Text;
            trader.Fax = FaxTextBox.Text;
            trader.Mobile = MobileTextBox.Text;
            trader.Email = EmailTextBox.Text;
            trader.Website = WebsitTextBox.Text;
            localDB.trySaveChanges();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            localDB = new EF_ADO();
            Trader trader = new Trader();
            trader.Name = NameTextBox.Text;
            trader.Telephone = TelephoneTextBox.Text;
            trader.Fax = FaxTextBox.Text;
            trader.Mobile = MobileTextBox.Text;
            trader.Email = EmailTextBox.Text;
            trader.Website = WebsitTextBox.Text;
            localDB.Traders.Add(trader);
            localDB.trySaveChanges();
            updateSelector();
        }
    }
}
