namespace OufInc
{
    partial class ItemPicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.productionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ValidDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemSelector
            // 
            this.ItemSelector.FormattingEnabled = true;
            this.ItemSelector.Location = new System.Drawing.Point(141, 30);
            this.ItemSelector.Name = "ItemSelector";
            this.ItemSelector.Size = new System.Drawing.Size(149, 21);
            this.ItemSelector.TabIndex = 0;
            this.ItemSelector.SelectedIndexChanged += new System.EventHandler(this.ItemSelector_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "production date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "valid date :";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(141, 62);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(149, 20);
            this.QuantityTextBox.TabIndex = 5;
            // 
            // productionDateTimePicker
            // 
            this.productionDateTimePicker.Location = new System.Drawing.Point(141, 89);
            this.productionDateTimePicker.Name = "productionDateTimePicker";
            this.productionDateTimePicker.Size = new System.Drawing.Size(149, 20);
            this.productionDateTimePicker.TabIndex = 6;
            // 
            // ValidDateTimePicker
            // 
            this.ValidDateTimePicker.Location = new System.Drawing.Point(141, 126);
            this.ValidDateTimePicker.Name = "ValidDateTimePicker";
            this.ValidDateTimePicker.Size = new System.Drawing.Size(149, 20);
            this.ValidDateTimePicker.TabIndex = 7;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(37, 175);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 8;
            this.AcceptButton.Text = "accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(215, 175);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ItemPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 210);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.ValidDateTimePicker);
            this.Controls.Add(this.productionDateTimePicker);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemSelector);
            this.Name = "ItemPicker";
            this.Text = "ItemPicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox ItemSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox QuantityTextBox;
        public System.Windows.Forms.DateTimePicker productionDateTimePicker;
        public System.Windows.Forms.DateTimePicker ValidDateTimePicker;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
    }
}