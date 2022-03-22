namespace OufInc
{
    partial class InvoiceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.WarehouseSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TraderSelector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InvoiceSelector = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eFProjectDataSet = new OufInc.EFProjectDataSet();
            this.invoice_ItemsTableAdapter = new OufInc.EFProjectDataSetTableAdapters.Invoice_ItemsTableAdapter();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFProjectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Warehouse ID  :";
            // 
            // WarehouseSelector
            // 
            this.WarehouseSelector.FormattingEnabled = true;
            this.WarehouseSelector.Location = new System.Drawing.Point(117, 42);
            this.WarehouseSelector.Name = "WarehouseSelector";
            this.WarehouseSelector.Size = new System.Drawing.Size(288, 21);
            this.WarehouseSelector.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Trader\'s ID  :";
            // 
            // TraderSelector
            // 
            this.TraderSelector.FormattingEnabled = true;
            this.TraderSelector.Location = new System.Drawing.Point(117, 76);
            this.TraderSelector.Name = "TraderSelector";
            this.TraderSelector.Size = new System.Drawing.Size(288, 21);
            this.TraderSelector.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Invoice ID :";
            // 
            // InvoiceSelector
            // 
            this.InvoiceSelector.FormattingEnabled = true;
            this.InvoiceSelector.Location = new System.Drawing.Point(117, 12);
            this.InvoiceSelector.Name = "InvoiceSelector";
            this.InvoiceSelector.Size = new System.Drawing.Size(288, 21);
            this.InvoiceSelector.TabIndex = 28;
            this.InvoiceSelector.SelectedIndexChanged += new System.EventHandler(this.InvoiceSelector_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Date of the Invoice :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 106);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(288, 20);
            this.dateTimePicker1.TabIndex = 31;
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
            this.dataGridView1.DataSource = this.invoiceItemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 143);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(394, 152);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.FillWeight = 99.13257F;
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.FillWeight = 99.81692F;
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // productionDateDataGridViewTextBoxColumn
            // 
            this.productionDateDataGridViewTextBoxColumn.DataPropertyName = "Production_Date";
            this.productionDateDataGridViewTextBoxColumn.FillWeight = 100.7188F;
            this.productionDateDataGridViewTextBoxColumn.HeaderText = "Production_Date";
            this.productionDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productionDateDataGridViewTextBoxColumn.Name = "productionDateDataGridViewTextBoxColumn";
            // 
            // validDateDataGridViewTextBoxColumn
            // 
            this.validDateDataGridViewTextBoxColumn.DataPropertyName = "Valid_Date";
            this.validDateDataGridViewTextBoxColumn.FillWeight = 100.3316F;
            this.validDateDataGridViewTextBoxColumn.HeaderText = "Valid_Date";
            this.validDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.validDateDataGridViewTextBoxColumn.Name = "validDateDataGridViewTextBoxColumn";
            // 
            // invoiceItemsBindingSource
            // 
            this.invoiceItemsBindingSource.DataMember = "Invoice_Items";
            this.invoiceItemsBindingSource.DataSource = this.eFProjectDataSet;
            // 
            // eFProjectDataSet
            // 
            this.eFProjectDataSet.DataSetName = "EFProjectDataSet";
            this.eFProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoice_ItemsTableAdapter
            // 
            this.invoice_ItemsTableAdapter.ClearBeforeFill = true;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.Location = new System.Drawing.Point(11, 302);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 28);
            this.AddButton.TabIndex = 33;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.AutoSize = true;
            this.EditButton.Location = new System.Drawing.Point(325, 299);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(80, 28);
            this.EditButton.TabIndex = 34;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(416, 334);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InvoiceSelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TraderSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WarehouseSelector);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eFProjectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EFProjectDataSet eFProjectDataSet;
        private System.Windows.Forms.BindingSource invoiceItemsBindingSource;
        private EFProjectDataSetTableAdapters.Invoice_ItemsTableAdapter invoice_ItemsTableAdapter;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox WarehouseSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TraderSelector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox InvoiceSelector;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validDateDataGridViewTextBoxColumn;
    }
}