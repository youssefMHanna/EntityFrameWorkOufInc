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
    public partial class StringDialogue : Form
    {
        public StringDialogue()
        {
            InitializeComponent();
        }
        public StringDialogue(String OldVal):this()
        {
            textBox1.Text = OldVal;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
            this.Close();
        }
    }
}
