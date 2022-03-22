namespace OufInc
{
    partial class TransferForm
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
            this.components = new System.ComponentModel.Container();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transeferItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eFProjectDataSet1 = new OufInc.EFProjectDataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.TransferSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TraderSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WarehouseFromSelector = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WarehouseToSelector = new System.Windows.Forms.ComboBox();
            this.eFProjectDataSet = new OufInc.EFProjectDataSet();
            this.invoiceItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoice_ItemsTableAdapter = new OufInc.EFProjectDataSetTableAdapters.Invoice_ItemsTableAdapter();
            this.transefer_ItemsTableAdapter = new OufInc.EFProjectDataSet1TableAdapters.Transefer_ItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transeferItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EditButton
            // 
            this.EditButton.AutoSize = true;
            this.EditButton.Location = new System.Drawing.Point(312, 282);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(80, 28);
            this.EditButton.TabIndex = 45;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.Location = new System.Drawing.Point(11, 282);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 28);
            this.AddButton.TabIndex = 44;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.productionDateDataGridViewTextBoxColumn,
            this.validDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transeferItemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 124);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(381, 152);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // productionDateDataGridViewTextBoxColumn
            // 
            this.productionDateDataGridViewTextBoxColumn.DataPropertyName = "Production_Date";
            this.productionDateDataGridViewTextBoxColumn.HeaderText = "Production_Date";
            this.productionDateDataGridViewTextBoxColumn.Name = "productionDateDataGridViewTextBoxColumn";
            // 
            // validDateDataGridViewTextBoxColumn
            // 
            this.validDateDataGridViewTextBoxColumn.DataPropertyName = "Valid_Date";
            this.validDateDataGridViewTextBoxColumn.HeaderText = "Valid_Date";
            this.validDateDataGridViewTextBoxColumn.Name = "validDateDataGridViewTextBoxColumn";
            // 
            // transeferItemsBindingSource
            // 
            this.transeferItemsBindingSource.DataMember = "Transefer_Items";
            this.transeferItemsBindingSource.DataSource = this.eFProjectDataSet1;
            // 
            // eFProjectDataSet1
            // 
            this.eFProjectDataSet1.DataSetName = "EFProjectDataSet1";
            this.eFProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Transfer ID :";
            // 
            // TransferSelector
            // 
            this.TransferSelector.FormattingEnabled = true;
            this.TransferSelector.Location = new System.Drawing.Point(120, 14);
            this.TransferSelector.Name = "TransferSelector";
            this.TransferSelector.Size = new System.Drawing.Size(272, 21);
            this.TransferSelector.TabIndex = 39;
            this.TransferSelector.SelectedIndexChanged += new System.EventHandler(this.InvoiceSelector_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Trader  :";
            // 
            // TraderSelector
            // 
            this.TraderSelector.FormattingEnabled = true;
            this.TraderSelector.Location = new System.Drawing.Point(120, 98);
            this.TraderSelector.Name = "TraderSelector";
            this.TraderSelector.Size = new System.Drawing.Size(272, 21);
            this.TraderSelector.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "From Warehouse  :";
            // 
            // WarehouseFromSelector
            // 
            this.WarehouseFromSelector.FormattingEnabled = true;
            this.WarehouseFromSelector.Location = new System.Drawing.Point(120, 44);
            this.WarehouseFromSelector.Name = "WarehouseFromSelector";
            this.WarehouseFromSelector.Size = new System.Drawing.Size(272, 21);
            this.WarehouseFromSelector.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "To Warehouse  :";
            // 
            // WarehouseToSelector
            // 
            this.WarehouseToSelector.FormattingEnabled = true;
            this.WarehouseToSelector.Location = new System.Drawing.Point(120, 71);
            this.WarehouseToSelector.Name = "WarehouseToSelector";
            this.WarehouseToSelector.Size = new System.Drawing.Size(272, 21);
            this.WarehouseToSelector.TabIndex = 46;
            // 
            // eFProjectDataSet
            // 
            this.eFProjectDataSet.DataSetName = "EFProjectDataSet";
            this.eFProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceItemsBindingSource
            // 
            this.invoiceItemsBindingSource.DataMember = "Invoice_Items";
            this.invoiceItemsBindingSource.DataSource = this.eFProjectDataSet;
            // 
            // invoice_ItemsTableAdapter
            // 
            this.invoice_ItemsTableAdapter.ClearBeforeFill = true;
            // 
            // transefer_ItemsTableAdapter
            // 
            this.transefer_ItemsTableAdapter.ClearBeforeFill = true;
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 321);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WarehouseToSelector);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TransferSelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TraderSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WarehouseFromSelector);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transeferItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFProjectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TransferSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TraderSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox WarehouseFromSelector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox WarehouseToSelector;
        private EFProjectDataSet eFProjectDataSet;
        private System.Windows.Forms.BindingSource invoiceItemsBindingSource;
        private EFProjectDataSetTableAdapters.Invoice_ItemsTableAdapter invoice_ItemsTableAdapter;
        private EFProjectDataSet1 eFProjectDataSet1;
        private System.Windows.Forms.BindingSource transeferItemsBindingSource;
        private EFProjectDataSet1TableAdapters.Transefer_ItemsTableAdapter transefer_ItemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validDateDataGridViewTextBoxColumn;
    }
}