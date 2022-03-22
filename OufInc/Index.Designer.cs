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
            this.OutPermitButton.Location = new System.Drawing.Point(510, 18);
            this.OutPermitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutPermitButton.Name = "OutPermitButton";
            this.OutPermitButton.Size = new System.Drawing.Size(120, 35);
            this.OutPermitButton.TabIndex = 4;
            this.OutPermitButton.Text = "Export Permit";
            this.OutPermitButton.UseVisualStyleBackColor = true;
            this.OutPermitButton.Click += new System.EventHandler(this.OutPermitButton_Click);
            // 
            // TransferPermitButton
            // 
            this.TransferPermitButton.Location = new System.Drawing.Point(639, 18);
            this.TransferPermitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TransferPermitButton.Name = "TransferPermitButton";
            this.TransferPermitButton.Size = new System.Drawing.Size(130, 35);
            this.TransferPermitButton.TabIndex = 5;
            this.TransferPermitButton.Text = "Transfer Permit";
            this.TransferPermitButton.UseVisualStyleBackColor = true;
            this.TransferPermitButton.Click += new System.EventHandler(this.TransferPermitButton_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 692);
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
    }
}

