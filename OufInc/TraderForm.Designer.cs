namespace OufInc
{
    partial class TraderForm
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
            this.TraderSelector = new System.Windows.Forms.ComboBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TelephoneTextBox = new System.Windows.Forms.TextBox();
            this.FaxTextBox = new System.Windows.Forms.TextBox();
            this.MobileTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.WebsitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TraderSelector
            // 
            this.TraderSelector.FormattingEnabled = true;
            this.TraderSelector.Location = new System.Drawing.Point(221, 71);
            this.TraderSelector.Margin = new System.Windows.Forms.Padding(6);
            this.TraderSelector.Name = "TraderSelector";
            this.TraderSelector.Size = new System.Drawing.Size(423, 33);
            this.TraderSelector.TabIndex = 0;
            this.TraderSelector.SelectedIndexChanged += new System.EventHandler(this.TraderSelector_SelectedIndexChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(221, 123);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(423, 31);
            this.NameTextBox.TabIndex = 1;
            // 
            // TelephoneTextBox
            // 
            this.TelephoneTextBox.Location = new System.Drawing.Point(221, 173);
            this.TelephoneTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.TelephoneTextBox.Name = "TelephoneTextBox";
            this.TelephoneTextBox.Size = new System.Drawing.Size(423, 31);
            this.TelephoneTextBox.TabIndex = 2;
            // 
            // FaxTextBox
            // 
            this.FaxTextBox.Location = new System.Drawing.Point(221, 223);
            this.FaxTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.FaxTextBox.Name = "FaxTextBox";
            this.FaxTextBox.Size = new System.Drawing.Size(423, 31);
            this.FaxTextBox.TabIndex = 3;
            // 
            // MobileTextBox
            // 
            this.MobileTextBox.Location = new System.Drawing.Point(221, 273);
            this.MobileTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.Size = new System.Drawing.Size(423, 31);
            this.MobileTextBox.TabIndex = 4;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(221, 323);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(423, 31);
            this.EmailTextBox.TabIndex = 5;
            // 
            // WebsitTextBox
            // 
            this.WebsitTextBox.Location = new System.Drawing.Point(221, 373);
            this.WebsitTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.WebsitTextBox.Name = "WebsitTextBox";
            this.WebsitTextBox.Size = new System.Drawing.Size(423, 31);
            this.WebsitTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Selector :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telephone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fax :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mobile :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 328);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 378);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Website :";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(118, 477);
            this.EditButton.Margin = new System.Windows.Forms.Padding(6);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(150, 44);
            this.EditButton.TabIndex = 14;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(398, 477);
            this.AddButton.Margin = new System.Windows.Forms.Padding(6);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 44);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TraderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 616);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WebsitTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.MobileTextBox);
            this.Controls.Add(this.FaxTextBox);
            this.Controls.Add(this.TelephoneTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.TraderSelector);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TraderForm";
            this.Text = "TraderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TraderSelector;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox TelephoneTextBox;
        private System.Windows.Forms.TextBox FaxTextBox;
        private System.Windows.Forms.TextBox MobileTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox WebsitTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
    }
}