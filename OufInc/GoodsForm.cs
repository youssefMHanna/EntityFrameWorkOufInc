using System;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace OufInc
{
    public partial class GoodsForm : System.Windows.Forms.Form
    {
        EF_ADO localDB;
        int? selected = null;
        public GoodsForm()
        {
            InitializeComponent();
            localDB = new EF_ADO();
            updateSelector();
        }
        private void updateSelector()
        {
            if (GoodsSelector.Items.Count > 0)
                GoodsSelector.Items.Clear();
            GoodsSelector.Items.AddRange(localDB.Goods.Select(a => a.Code.ToString()).ToArray());
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            localDB = new EF_ADO();
            Good good = new Good();
            good.Goods_Name = NameTextBox.Text;
            localDB.Goods.Add(good);
            localDB.trySaveChanges();
            updateSelector();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            localDB = new EF_ADO();
            selected = int.Parse(GoodsSelector.SelectedItem.ToString());
            Good good = localDB.Goods.Find(selected);
            good.Goods_Name = NameTextBox.Text;
            localDB.trySaveChanges();
        }

        private void GoodsSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            localDB = new EF_ADO();
            selected = int.Parse(GoodsSelector.SelectedItem.ToString());
            Good good = localDB.Goods.Find(selected);
            NameTextBox.Text = good.Goods_Name;
            if (DimensionsListBox.Items.Count > 0)
                DimensionsListBox.Items.Clear();
            DimensionsListBox.Items.AddRange(good.Goods_Goods_Dimensions.Select(a => a.Goods_Dimensions.ToString()).ToArray());
        }

        private void AddDimButton_Click(object sender, EventArgs e)
        {
            localDB = new EF_ADO();
            if (selected == null)
            {
                MessageBox.Show("select item first to add dims to");
                return;
            }
            Good good = localDB.Goods.Find(selected);

            StringDialogue stringDialogue = new StringDialogue();
            if (stringDialogue.ShowDialog() == DialogResult.OK)
            {
                Goods_Goods_Dimensions goods_Goods_Dimensions = new Goods_Goods_Dimensions();
                goods_Goods_Dimensions.Goods_Dimensions = stringDialogue.textBox1.Text;
                good.Goods_Goods_Dimensions.Add(goods_Goods_Dimensions);
                DimensionsListBox.Items.Add(stringDialogue.textBox1.Text);
            }

            localDB.trySaveChanges();
        }

        private void EditDimButton_Click(object sender, EventArgs e)
        {
            localDB = new EF_ADO();
            if (selected == null)
            {
                MessageBox.Show("select item first to edit its dims");
                return;
            }

            Good good = localDB.Goods.Find(selected);

            StringDialogue stringDialogue = new StringDialogue(DimensionsListBox.SelectedItem.ToString());
            if (stringDialogue.ShowDialog() == DialogResult.OK)
            {
                Goods_Goods_Dimensions goods_Goods_Dimensions = localDB.Goods_Dimensions.Find(DimensionsListBox.SelectedItem.ToString(), selected );
                localDB.Goods_Dimensions.Remove(goods_Goods_Dimensions);

                goods_Goods_Dimensions = new Goods_Goods_Dimensions();
                goods_Goods_Dimensions.Goods_Dimensions = stringDialogue.textBox1.Text;
                good.Goods_Goods_Dimensions.Add(goods_Goods_Dimensions);

                DimensionsListBox.Items.Remove(DimensionsListBox.SelectedItem);
                DimensionsListBox.Items.Add(stringDialogue.textBox1.Text);
            }
            localDB.trySaveChanges();
        }
    }
}
