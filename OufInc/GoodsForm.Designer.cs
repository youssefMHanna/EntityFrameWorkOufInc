namespace OufInc
{
    partial class GoodsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.GoodsSelector = new System.Windows.Forms.ComboBox();
            this.DimensionsListBox = new System.Windows.Forms.ListBox();
            this.AddDimButton = new System.Windows.Forms.Button();
            this.EditDimButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(497, 356);
            this.AddButton.Margin = new System.Windows.Forms.Padding(6);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 44);
            this.AddButton.TabIndex = 41;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(124, 356);
            this.EditButton.Margin = new System.Windows.Forms.Padding(6);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(150, 44);
            this.EditButton.TabIndex = 40;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Code :";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(290, 119);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(423, 31);
            this.NameTextBox.TabIndex = 33;
            // 
            // GoodsSelector
            // 
            this.GoodsSelector.FormattingEnabled = true;
            this.GoodsSelector.Location = new System.Drawing.Point(290, 50);
            this.GoodsSelector.Margin = new System.Windows.Forms.Padding(6);
            this.GoodsSelector.Name = "GoodsSelector";
            this.GoodsSelector.Size = new System.Drawing.Size(423, 33);
            this.GoodsSelector.TabIndex = 32;
            this.GoodsSelector.SelectedIndexChanged += new System.EventHandler(this.GoodsSelector_SelectedIndexChanged);
            // 
            // DimensionsListBox
            // 
            this.DimensionsListBox.FormattingEnabled = true;
            this.DimensionsListBox.ItemHeight = 25;
            this.DimensionsListBox.Location = new System.Drawing.Point(93, 188);
            this.DimensionsListBox.Name = "DimensionsListBox";
            this.DimensionsListBox.Size = new System.Drawing.Size(491, 104);
            this.DimensionsListBox.TabIndex = 42;
            // 
            // AddDimButton
            // 
            this.AddDimButton.Location = new System.Drawing.Point(593, 188);
            this.AddDimButton.Margin = new System.Windows.Forms.Padding(6);
            this.AddDimButton.Name = "AddDimButton";
            this.AddDimButton.Size = new System.Drawing.Size(120, 44);
            this.AddDimButton.TabIndex = 43;
            this.AddDimButton.Text = "Add";
            this.AddDimButton.UseVisualStyleBackColor = true;
            this.AddDimButton.Click += new System.EventHandler(this.AddDimButton_Click);
            // 
            // EditDimButton
            // 
            this.EditDimButton.Location = new System.Drawing.Point(593, 244);
            this.EditDimButton.Margin = new System.Windows.Forms.Padding(6);
            this.EditDimButton.Name = "EditDimButton";
            this.EditDimButton.Size = new System.Drawing.Size(120, 44);
            this.EditDimButton.TabIndex = 44;
            this.EditDimButton.Text = "Edit";
            this.EditDimButton.UseVisualStyleBackColor = true;
            this.EditDimButton.Click += new System.EventHandler(this.EditDimButton_Click);
            // 
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditDimButton);
            this.Controls.Add(this.AddDimButton);
            this.Controls.Add(this.DimensionsListBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.GoodsSelector);
            this.Name = "GoodsForm";
            this.Text = "Goods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox GoodsSelector;
        private System.Windows.Forms.ListBox DimensionsListBox;
        private System.Windows.Forms.Button AddDimButton;
        private System.Windows.Forms.Button EditDimButton;
    }
}