namespace OufInc
{
    partial class WarehouseForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ManagerTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.WarehouseSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(501, 365);
            this.AddButton.Margin = new System.Windows.Forms.Padding(6);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 44);
            this.AddButton.TabIndex = 31;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(128, 365);
            this.EditButton.Margin = new System.Windows.Forms.Padding(6);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(150, 44);
            this.EditButton.TabIndex = 30;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Manager :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID Selector :";
            // 
            // ManagerTextBox
            // 
            this.ManagerTextBox.Location = new System.Drawing.Point(294, 262);
            this.ManagerTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.ManagerTextBox.Name = "ManagerTextBox";
            this.ManagerTextBox.Size = new System.Drawing.Size(423, 31);
            this.ManagerTextBox.TabIndex = 19;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(294, 195);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(423, 31);
            this.AddressTextBox.TabIndex = 18;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(294, 128);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(423, 31);
            this.NameTextBox.TabIndex = 17;
            // 
            // WarehouseSelector
            // 
            this.WarehouseSelector.FormattingEnabled = true;
            this.WarehouseSelector.Location = new System.Drawing.Point(294, 59);
            this.WarehouseSelector.Margin = new System.Windows.Forms.Padding(6);
            this.WarehouseSelector.Name = "WarehouseSelector";
            this.WarehouseSelector.Size = new System.Drawing.Size(423, 33);
            this.WarehouseSelector.TabIndex = 16;
            this.WarehouseSelector.SelectedIndexChanged += new System.EventHandler(this.WarehouseSelector_SelectedIndexChanged);
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 457);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManagerTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.WarehouseSelector);
            this.Name = "WarehouseForm";
            this.Text = "WarehouseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ManagerTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox WarehouseSelector;
    }
}