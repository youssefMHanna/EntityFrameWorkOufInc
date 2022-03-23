namespace OufInc
{
    partial class Index
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
            this.TraderButton = new System.Windows.Forms.Button();
            this.WarehouseButton = new System.Windows.Forms.Button();
            this.GoodsButton = new System.Windows.Forms.Button();
            this.InPermitButton = new System.Windows.Forms.Button();
            this.OutPermitButton = new System.Windows.Forms.Button();
            this.TransferPermitButton = new System.Windows.Forms.Button();
            this.WarehouseReport = new System.Windows.Forms.Button();
            this.ItemsReport = new System.Windows.Forms.Button();
            this.DatedItemsReport = new System.Windows.Forms.Button();
            this.AboutToExpireItemsReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TraderButton
            // 
            this.TraderButton.Location = new System.Drawing.Point(18, 18);
            this.TraderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TraderButton.Name = "TraderButton";
            this.TraderButton.Size = new System.Drawing.Size(112, 35);
            this.TraderButton.TabIndex = 0;
            this.TraderButton.Text = "Trader";
            this.TraderButton.UseVisualStyleBackColor = true;
            this.TraderButton.Click += new System.EventHandler(this.TraderButton_Click);
            // 
            // WarehouseButton
            // 
            this.WarehouseButton.Location = new System.Drawing.Point(140, 18);
            this.WarehouseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WarehouseButton.Name = "WarehouseButton";
            this.WarehouseButton.Size = new System.Drawing.Size(112, 35);
            this.WarehouseButton.TabIndex = 1;
            this.WarehouseButton.Text = "Warehouse";
            this.WarehouseButton.UseVisualStyleBackColor = true;
            this.WarehouseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoodsButton
            // 
            this.GoodsButton.Location = new System.Drawing.Point(261, 18);
            this.GoodsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GoodsButton.Name = "GoodsButton";
            this.GoodsButton.Size = new System.Drawing.Size(112, 35);
            this.GoodsButton.TabIndex = 2;
            this.GoodsButton.Text = "Goods";
            this.GoodsButton.UseVisualStyleBackColor = true;
            this.GoodsButton.Click += new System.EventHandler(this.GoodsButton_Click);
            // 
            // InPermitButton
            // 
            this.InPermitButton.Location = new System.Drawing.Point(382, 18);
            this.InPermitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InPermitButton.Name = "InPermitButton";
            this.InPermitButton.Size = new System.Drawing.Size(117, 35);
            this.InPermitButton.TabIndex = 3;
            this.InPermitButton.Text = "Import Permit";
            this.InPermitButton.UseVisualStyleBackColor = true;
            this.InPermitButton.Click += new System.EventHandler(this.InPermitButton_Click);
            // 
            // OutPermitButton
            // 
            this.OutPermitButton.Location = new System.Drawing.Point(507, 18);
            this.OutPermitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutPermitButton.Name = "OutPermitButton";
            this.OutPermitButton.Size = new System.Drawing.Size(117, 35);
            this.OutPermitButton.TabIndex = 4;
            this.OutPermitButton.Text = "Export Permit";
            this.OutPermitButton.UseVisualStyleBackColor = true;
            this.OutPermitButton.Click += new System.EventHandler(this.OutPermitButton_Click);
            // 
            // TransferPermitButton
            // 
            this.TransferPermitButton.Location = new System.Drawing.Point(632, 18);
            this.TransferPermitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TransferPermitButton.Name = "TransferPermitButton";
            this.TransferPermitButton.Size = new System.Drawing.Size(117, 35);
            this.TransferPermitButton.TabIndex = 5;
            this.TransferPermitButton.Text = "Transfer Permit";
            this.TransferPermitButton.UseVisualStyleBackColor = true;
            this.TransferPermitButton.Click += new System.EventHandler(this.TransferPermitButton_Click);
            // 
            // WarehouseReport
            // 
            this.WarehouseReport.Location = new System.Drawing.Point(18, 63);
            this.WarehouseReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WarehouseReport.Name = "WarehouseReport";
            this.WarehouseReport.Size = new System.Drawing.Size(234, 86);
            this.WarehouseReport.TabIndex = 6;
            this.WarehouseReport.Text = "Warehouse Items Report";
            this.WarehouseReport.UseVisualStyleBackColor = true;
            this.WarehouseReport.Click += new System.EventHandler(this.WarehouseReport_Click);
            // 
            // ItemsReport
            // 
            this.ItemsReport.Location = new System.Drawing.Point(260, 63);
            this.ItemsReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ItemsReport.Name = "ItemsReport";
            this.ItemsReport.Size = new System.Drawing.Size(238, 86);
            this.ItemsReport.TabIndex = 7;
            this.ItemsReport.Text = "Item Movemet Report";
            this.ItemsReport.UseVisualStyleBackColor = true;
            this.ItemsReport.Click += new System.EventHandler(this.ItemsReport_Click);
            // 
            // DatedItemsReport
            // 
            this.DatedItemsReport.Location = new System.Drawing.Point(510, 63);
            this.DatedItemsReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatedItemsReport.Name = "DatedItemsReport";
            this.DatedItemsReport.Size = new System.Drawing.Size(239, 86);
            this.DatedItemsReport.TabIndex = 8;
            this.DatedItemsReport.Text = "Dated Items Report";
            this.DatedItemsReport.UseVisualStyleBackColor = true;
            this.DatedItemsReport.Click += new System.EventHandler(this.DatedItemsReport_Click);
            // 
            // AboutToExpireItemsReport
            // 
            this.AboutToExpireItemsReport.Location = new System.Drawing.Point(140, 159);
            this.AboutToExpireItemsReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AboutToExpireItemsReport.Name = "AboutToExpireItemsReport";
            this.AboutToExpireItemsReport.Size = new System.Drawing.Size(484, 86);
            this.AboutToExpireItemsReport.TabIndex = 9;
            this.AboutToExpireItemsReport.Text = "about to expire Items Report";
            this.AboutToExpireItemsReport.UseVisualStyleBackColor = true;
            this.AboutToExpireItemsReport.Click += new System.EventHandler(this.AboutToExpireItemsReport_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(793, 271);
            this.Controls.Add(this.AboutToExpireItemsReport);
            this.Controls.Add(this.DatedItemsReport);
            this.Controls.Add(this.ItemsReport);
            this.Controls.Add(this.WarehouseReport);
            this.Controls.Add(this.TransferPermitButton);
            this.Controls.Add(this.OutPermitButton);
            this.Controls.Add(this.InPermitButton);
            this.Controls.Add(this.GoodsButton);
            this.Controls.Add(this.WarehouseButton);
            this.Controls.Add(this.TraderButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Index";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TraderButton;
        private System.Windows.Forms.Button WarehouseButton;
        private System.Windows.Forms.Button GoodsButton;
        private System.Windows.Forms.Button InPermitButton;
        private System.Windows.Forms.Button OutPermitButton;
        private System.Windows.Forms.Button TransferPermitButton;
        private System.Windows.Forms.Button WarehouseReport;
        private System.Windows.Forms.Button ItemsReport;
        private System.Windows.Forms.Button DatedItemsReport;
        private System.Windows.Forms.Button AboutToExpireItemsReport;
    }
}

