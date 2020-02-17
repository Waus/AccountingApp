namespace JPK_generator
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditBtn = new System.Windows.Forms.Button();
            this.invoiceidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountnetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountvatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractoraddress1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractoraddress2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractornipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofissueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofsaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceidDataGridViewTextBoxColumn,
            this.invoicenumberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.amountnetDataGridViewTextBoxColumn,
            this.amountvatDataGridViewTextBoxColumn,
            this.vatrateDataGridViewTextBoxColumn,
            this.contractornameDataGridViewTextBoxColumn,
            this.contractoraddress1DataGridViewTextBoxColumn,
            this.contractoraddress2DataGridViewTextBoxColumn,
            this.contractornipDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn,
            this.dateofissueDataGridViewTextBoxColumn,
            this.dateofsaleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 86);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(749, 337);
            this.dataGridView1.TabIndex = 4;
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(21, 21);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 5;
            this.EditBtn.Text = "Edytuj";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // invoiceidDataGridViewTextBoxColumn
            // 
            this.invoiceidDataGridViewTextBoxColumn.DataPropertyName = "invoice_id";
            this.invoiceidDataGridViewTextBoxColumn.HeaderText = "ID faktury";
            this.invoiceidDataGridViewTextBoxColumn.Name = "invoiceidDataGridViewTextBoxColumn";
            this.invoiceidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoicenumberDataGridViewTextBoxColumn
            // 
            this.invoicenumberDataGridViewTextBoxColumn.DataPropertyName = "invoice_number";
            this.invoicenumberDataGridViewTextBoxColumn.HeaderText = "Numer faktury";
            this.invoicenumberDataGridViewTextBoxColumn.Name = "invoicenumberDataGridViewTextBoxColumn";
            this.invoicenumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountnetDataGridViewTextBoxColumn
            // 
            this.amountnetDataGridViewTextBoxColumn.DataPropertyName = "amount_net";
            this.amountnetDataGridViewTextBoxColumn.HeaderText = "Wartość netto";
            this.amountnetDataGridViewTextBoxColumn.Name = "amountnetDataGridViewTextBoxColumn";
            this.amountnetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountvatDataGridViewTextBoxColumn
            // 
            this.amountvatDataGridViewTextBoxColumn.DataPropertyName = "amount_vat";
            this.amountvatDataGridViewTextBoxColumn.HeaderText = "Wartość VAT";
            this.amountvatDataGridViewTextBoxColumn.Name = "amountvatDataGridViewTextBoxColumn";
            this.amountvatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vatrateDataGridViewTextBoxColumn
            // 
            this.vatrateDataGridViewTextBoxColumn.DataPropertyName = "vat_rate";
            this.vatrateDataGridViewTextBoxColumn.HeaderText = "Stopa VAT";
            this.vatrateDataGridViewTextBoxColumn.Name = "vatrateDataGridViewTextBoxColumn";
            this.vatrateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contractornameDataGridViewTextBoxColumn
            // 
            this.contractornameDataGridViewTextBoxColumn.DataPropertyName = "contractor_name";
            this.contractornameDataGridViewTextBoxColumn.HeaderText = "Nazwa kontrahenta";
            this.contractornameDataGridViewTextBoxColumn.Name = "contractornameDataGridViewTextBoxColumn";
            this.contractornameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contractoraddress1DataGridViewTextBoxColumn
            // 
            this.contractoraddress1DataGridViewTextBoxColumn.DataPropertyName = "contractor_address1";
            this.contractoraddress1DataGridViewTextBoxColumn.HeaderText = "Adres kontrahenta 1";
            this.contractoraddress1DataGridViewTextBoxColumn.Name = "contractoraddress1DataGridViewTextBoxColumn";
            this.contractoraddress1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contractoraddress2DataGridViewTextBoxColumn
            // 
            this.contractoraddress2DataGridViewTextBoxColumn.DataPropertyName = "contractor_address2";
            this.contractoraddress2DataGridViewTextBoxColumn.HeaderText = "Adres kontrahenta 2";
            this.contractoraddress2DataGridViewTextBoxColumn.Name = "contractoraddress2DataGridViewTextBoxColumn";
            this.contractoraddress2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contractornipDataGridViewTextBoxColumn
            // 
            this.contractornipDataGridViewTextBoxColumn.DataPropertyName = "contractor_nip";
            this.contractornipDataGridViewTextBoxColumn.HeaderText = "NIP kontrahenta";
            this.contractornipDataGridViewTextBoxColumn.Name = "contractornipDataGridViewTextBoxColumn";
            this.contractornipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "income";
            this.incomeDataGridViewTextBoxColumn.HeaderText = "Faktura sprzedaży";
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            this.incomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateofissueDataGridViewTextBoxColumn
            // 
            this.dateofissueDataGridViewTextBoxColumn.DataPropertyName = "date_of_issue";
            this.dateofissueDataGridViewTextBoxColumn.HeaderText = "Data wystawienia";
            this.dateofissueDataGridViewTextBoxColumn.Name = "dateofissueDataGridViewTextBoxColumn";
            this.dateofissueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateofsaleDataGridViewTextBoxColumn
            // 
            this.dateofsaleDataGridViewTextBoxColumn.DataPropertyName = "date_of_sale";
            this.dateofsaleDataGridViewTextBoxColumn.HeaderText = "Data sprzedaży";
            this.dateofsaleDataGridViewTextBoxColumn.Name = "dateofsaleDataGridViewTextBoxColumn";
            this.dateofsaleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(JPK_generator.Model.invoice);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 435);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Generator JPK";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountnetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountvatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractoraddress1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractoraddress2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractornipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofissueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofsaleDataGridViewTextBoxColumn;
    }
}

