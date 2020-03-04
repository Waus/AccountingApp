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
            this.invoicenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountnetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountvatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractornipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofissueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofsaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddNewBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.MainFormTabControl = new System.Windows.Forms.TabControl();
            this.InvoicesTab = new System.Windows.Forms.TabPage();
            this.JpkTab = new System.Windows.Forms.TabPage();
            this.GenerateJpkBtn = new System.Windows.Forms.Button();
            this.DateToLbl = new System.Windows.Forms.Label();
            this.DateToTB = new System.Windows.Forms.TextBox();
            this.DateFromLbl = new System.Windows.Forms.Label();
            this.DateFromTB = new System.Windows.Forms.TextBox();
            this.ConfigTab = new System.Windows.Forms.TabPage();
            this.PathForJpkLbl = new System.Windows.Forms.Label();
            this.PathForJpkTB = new System.Windows.Forms.TextBox();
            this.bindingSourceConfig = new System.Windows.Forms.BindingSource(this.components);
            this.SaveConfigBtn = new System.Windows.Forms.Button();
            this.FormVariantLbl = new System.Windows.Forms.Label();
            this.FormVariantTB = new System.Windows.Forms.TextBox();
            this.PurposeOfSubmissionLbl = new System.Windows.Forms.Label();
            this.PurposeOfSubmissionTB = new System.Windows.Forms.TextBox();
            this.MyEmailLbl = new System.Windows.Forms.Label();
            this.MyEmailTB = new System.Windows.Forms.TextBox();
            this.MyNipLbl = new System.Windows.Forms.Label();
            this.MyNipTB = new System.Windows.Forms.TextBox();
            this.MyAddressLbl = new System.Windows.Forms.Label();
            this.MyAddressTB = new System.Windows.Forms.TextBox();
            this.MyNameLbl = new System.Windows.Forms.Label();
            this.MyNameTB = new System.Windows.Forms.TextBox();
            this.SystemNameLbl = new System.Windows.Forms.Label();
            this.SystemNameTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.MainFormTabControl.SuspendLayout();
            this.InvoicesTab.SuspendLayout();
            this.JpkTab.SuspendLayout();
            this.ConfigTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoicenumberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.amountnetDataGridViewTextBoxColumn,
            this.amountvatDataGridViewTextBoxColumn,
            this.vatrateDataGridViewTextBoxColumn,
            this.contractornameDataGridViewTextBoxColumn,
            this.contractornipDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn,
            this.dateofissueDataGridViewTextBoxColumn,
            this.dateofsaleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-145, 35);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1177, 337);
            this.dataGridView1.TabIndex = 4;
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
            // contractornipDataGridViewTextBoxColumn
            // 
            this.contractornipDataGridViewTextBoxColumn.DataPropertyName = "contractor_nip";
            this.contractornipDataGridViewTextBoxColumn.HeaderText = "NIP kontrahenta";
            this.contractornipDataGridViewTextBoxColumn.Name = "contractornipDataGridViewTextBoxColumn";
            this.contractornipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "incomeText";
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
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(87, 6);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 5;
            this.EditBtn.Text = "Edytuj";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddNewBtn
            // 
            this.AddNewBtn.Location = new System.Drawing.Point(6, 6);
            this.AddNewBtn.Name = "AddNewBtn";
            this.AddNewBtn.Size = new System.Drawing.Size(75, 23);
            this.AddNewBtn.TabIndex = 6;
            this.AddNewBtn.Text = "Dodaj nową";
            this.AddNewBtn.UseVisualStyleBackColor = true;
            this.AddNewBtn.Click += new System.EventHandler(this.AddNewBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(168, 6);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Usuń";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // MainFormTabControl
            // 
            this.MainFormTabControl.Controls.Add(this.InvoicesTab);
            this.MainFormTabControl.Controls.Add(this.JpkTab);
            this.MainFormTabControl.Controls.Add(this.ConfigTab);
            this.MainFormTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainFormTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainFormTabControl.Name = "MainFormTabControl";
            this.MainFormTabControl.SelectedIndex = 0;
            this.MainFormTabControl.Size = new System.Drawing.Size(789, 411);
            this.MainFormTabControl.TabIndex = 8;
            this.MainFormTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.MainFormTabControl_Selecting);
            // 
            // InvoicesTab
            // 
            this.InvoicesTab.Controls.Add(this.AddNewBtn);
            this.InvoicesTab.Controls.Add(this.dataGridView1);
            this.InvoicesTab.Controls.Add(this.DeleteBtn);
            this.InvoicesTab.Controls.Add(this.EditBtn);
            this.InvoicesTab.Location = new System.Drawing.Point(4, 22);
            this.InvoicesTab.Name = "InvoicesTab";
            this.InvoicesTab.Padding = new System.Windows.Forms.Padding(3);
            this.InvoicesTab.Size = new System.Drawing.Size(781, 385);
            this.InvoicesTab.TabIndex = 0;
            this.InvoicesTab.Text = "Faktury";
            this.InvoicesTab.UseVisualStyleBackColor = true;
            // 
            // JpkTab
            // 
            this.JpkTab.Controls.Add(this.GenerateJpkBtn);
            this.JpkTab.Controls.Add(this.DateToLbl);
            this.JpkTab.Controls.Add(this.DateToTB);
            this.JpkTab.Controls.Add(this.DateFromLbl);
            this.JpkTab.Controls.Add(this.DateFromTB);
            this.JpkTab.Location = new System.Drawing.Point(4, 22);
            this.JpkTab.Name = "JpkTab";
            this.JpkTab.Padding = new System.Windows.Forms.Padding(3);
            this.JpkTab.Size = new System.Drawing.Size(781, 385);
            this.JpkTab.TabIndex = 1;
            this.JpkTab.Text = "JPK";
            this.JpkTab.UseVisualStyleBackColor = true;
            // 
            // GenerateJpkBtn
            // 
            this.GenerateJpkBtn.Location = new System.Drawing.Point(660, 51);
            this.GenerateJpkBtn.Name = "GenerateJpkBtn";
            this.GenerateJpkBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerateJpkBtn.TabIndex = 6;
            this.GenerateJpkBtn.Text = "Generuj JPK";
            this.GenerateJpkBtn.UseVisualStyleBackColor = true;
            this.GenerateJpkBtn.Click += new System.EventHandler(this.GenerateJpkBtn_Click);
            // 
            // DateToLbl
            // 
            this.DateToLbl.AutoSize = true;
            this.DateToLbl.Location = new System.Drawing.Point(257, 28);
            this.DateToLbl.Name = "DateToLbl";
            this.DateToLbl.Size = new System.Drawing.Size(45, 13);
            this.DateToLbl.TabIndex = 5;
            this.DateToLbl.Text = "Data do";
            // 
            // DateToTB
            // 
            this.DateToTB.Location = new System.Drawing.Point(260, 54);
            this.DateToTB.Name = "DateToTB";
            this.DateToTB.Size = new System.Drawing.Size(197, 20);
            this.DateToTB.TabIndex = 4;
            // 
            // DateFromLbl
            // 
            this.DateFromLbl.AutoSize = true;
            this.DateFromLbl.Location = new System.Drawing.Point(26, 28);
            this.DateFromLbl.Name = "DateFromLbl";
            this.DateFromLbl.Size = new System.Drawing.Size(45, 13);
            this.DateFromLbl.TabIndex = 3;
            this.DateFromLbl.Text = "Data od";
            // 
            // DateFromTB
            // 
            this.DateFromTB.Location = new System.Drawing.Point(29, 54);
            this.DateFromTB.Name = "DateFromTB";
            this.DateFromTB.Size = new System.Drawing.Size(197, 20);
            this.DateFromTB.TabIndex = 2;
            // 
            // ConfigTab
            // 
            this.ConfigTab.Controls.Add(this.SystemNameLbl);
            this.ConfigTab.Controls.Add(this.SystemNameTB);
            this.ConfigTab.Controls.Add(this.PathForJpkLbl);
            this.ConfigTab.Controls.Add(this.PathForJpkTB);
            this.ConfigTab.Controls.Add(this.SaveConfigBtn);
            this.ConfigTab.Controls.Add(this.FormVariantLbl);
            this.ConfigTab.Controls.Add(this.FormVariantTB);
            this.ConfigTab.Controls.Add(this.PurposeOfSubmissionLbl);
            this.ConfigTab.Controls.Add(this.PurposeOfSubmissionTB);
            this.ConfigTab.Controls.Add(this.MyEmailLbl);
            this.ConfigTab.Controls.Add(this.MyEmailTB);
            this.ConfigTab.Controls.Add(this.MyNipLbl);
            this.ConfigTab.Controls.Add(this.MyNipTB);
            this.ConfigTab.Controls.Add(this.MyAddressLbl);
            this.ConfigTab.Controls.Add(this.MyAddressTB);
            this.ConfigTab.Controls.Add(this.MyNameLbl);
            this.ConfigTab.Controls.Add(this.MyNameTB);
            this.ConfigTab.Location = new System.Drawing.Point(4, 22);
            this.ConfigTab.Name = "ConfigTab";
            this.ConfigTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigTab.Size = new System.Drawing.Size(781, 385);
            this.ConfigTab.TabIndex = 2;
            this.ConfigTab.Text = "Konfiguracja";
            this.ConfigTab.UseVisualStyleBackColor = true;
            // 
            // PathForJpkLbl
            // 
            this.PathForJpkLbl.AutoSize = true;
            this.PathForJpkLbl.Location = new System.Drawing.Point(25, 301);
            this.PathForJpkLbl.Name = "PathForJpkLbl";
            this.PathForJpkLbl.Size = new System.Drawing.Size(179, 13);
            this.PathForJpkLbl.TabIndex = 16;
            this.PathForJpkLbl.Text = "Ścieżka do generowania plików JPK";
            // 
            // PathForJpkTB
            // 
            this.PathForJpkTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceConfig, "path_for_jpk", true));
            this.PathForJpkTB.Location = new System.Drawing.Point(28, 327);
            this.PathForJpkTB.Name = "PathForJpkTB";
            this.PathForJpkTB.Size = new System.Drawing.Size(699, 20);
            this.PathForJpkTB.TabIndex = 15;
            // 
            // bindingSourceConfig
            // 
            this.bindingSourceConfig.DataSource = typeof(JPK_generator.Model.config);
            // 
            // SaveConfigBtn
            // 
            this.SaveConfigBtn.Location = new System.Drawing.Point(652, 42);
            this.SaveConfigBtn.Name = "SaveConfigBtn";
            this.SaveConfigBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveConfigBtn.TabIndex = 14;
            this.SaveConfigBtn.Text = "Zapisz";
            this.SaveConfigBtn.UseVisualStyleBackColor = true;
            this.SaveConfigBtn.Click += new System.EventHandler(this.SaveConfigBtn_Click);
            // 
            // FormVariantLbl
            // 
            this.FormVariantLbl.AutoSize = true;
            this.FormVariantLbl.Location = new System.Drawing.Point(304, 87);
            this.FormVariantLbl.Name = "FormVariantLbl";
            this.FormVariantLbl.Size = new System.Drawing.Size(95, 13);
            this.FormVariantLbl.TabIndex = 13;
            this.FormVariantLbl.Text = "Wariant formularza";
            // 
            // FormVariantTB
            // 
            this.FormVariantTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceConfig, "form_variant", true));
            this.FormVariantTB.Location = new System.Drawing.Point(307, 113);
            this.FormVariantTB.Name = "FormVariantTB";
            this.FormVariantTB.Size = new System.Drawing.Size(197, 20);
            this.FormVariantTB.TabIndex = 12;
            // 
            // PurposeOfSubmissionLbl
            // 
            this.PurposeOfSubmissionLbl.AutoSize = true;
            this.PurposeOfSubmissionLbl.Location = new System.Drawing.Point(304, 20);
            this.PurposeOfSubmissionLbl.Name = "PurposeOfSubmissionLbl";
            this.PurposeOfSubmissionLbl.Size = new System.Drawing.Size(65, 13);
            this.PurposeOfSubmissionLbl.TabIndex = 11;
            this.PurposeOfSubmissionLbl.Text = "Cel złożenia";
            // 
            // PurposeOfSubmissionTB
            // 
            this.PurposeOfSubmissionTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceConfig, "purpose_of_submission", true));
            this.PurposeOfSubmissionTB.Location = new System.Drawing.Point(307, 46);
            this.PurposeOfSubmissionTB.Name = "PurposeOfSubmissionTB";
            this.PurposeOfSubmissionTB.Size = new System.Drawing.Size(197, 20);
            this.PurposeOfSubmissionTB.TabIndex = 10;
            // 
            // MyEmailLbl
            // 
            this.MyEmailLbl.AutoSize = true;
            this.MyEmailLbl.Location = new System.Drawing.Point(25, 229);
            this.MyEmailLbl.Name = "MyEmailLbl";
            this.MyEmailLbl.Size = new System.Drawing.Size(51, 13);
            this.MyEmailLbl.TabIndex = 9;
            this.MyEmailLbl.Text = "Mój email";
            // 
            // MyEmailTB
            // 
            this.MyEmailTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceConfig, "my_email", true));
            this.MyEmailTB.Location = new System.Drawing.Point(28, 255);
            this.MyEmailTB.Name = "MyEmailTB";
            this.MyEmailTB.Size = new System.Drawing.Size(197, 20);
            this.MyEmailTB.TabIndex = 8;
            // 
            // MyNipLbl
            // 
            this.MyNipLbl.AutoSize = true;
            this.MyNipLbl.Location = new System.Drawing.Point(25, 157);
            this.MyNipLbl.Name = "MyNipLbl";
            this.MyNipLbl.Size = new System.Drawing.Size(45, 13);
            this.MyNipLbl.TabIndex = 7;
            this.MyNipLbl.Text = "Mój NIP";
            // 
            // MyNipTB
            // 
            this.MyNipTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceConfig, "my_nip", true));
            this.MyNipTB.Location = new System.Drawing.Point(28, 183);
            this.MyNipTB.Name = "MyNipTB";
            this.MyNipTB.Size = new System.Drawing.Size(197, 20);
            this.MyNipTB.TabIndex = 6;
            // 
            // MyAddressLbl
            // 
            this.MyAddressLbl.AutoSize = true;
            this.MyAddressLbl.Location = new System.Drawing.Point(25, 87);
            this.MyAddressLbl.Name = "MyAddressLbl";
            this.MyAddressLbl.Size = new System.Drawing.Size(53, 13);
            this.MyAddressLbl.TabIndex = 3;
            this.MyAddressLbl.Text = "Mój adres";
            // 
            // MyAddressTB
            // 
            this.MyAddressTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceConfig, "my_address", true));
            this.MyAddressTB.Location = new System.Drawing.Point(28, 113);
            this.MyAddressTB.Name = "MyAddressTB";
            this.MyAddressTB.Size = new System.Drawing.Size(197, 20);
            this.MyAddressTB.TabIndex = 2;
            // 
            // MyNameLbl
            // 
            this.MyNameLbl.AutoSize = true;
            this.MyNameLbl.Location = new System.Drawing.Point(25, 20);
            this.MyNameLbl.Name = "MyNameLbl";
            this.MyNameLbl.Size = new System.Drawing.Size(64, 13);
            this.MyNameLbl.TabIndex = 1;
            this.MyNameLbl.Text = "Moja nazwa";
            // 
            // MyNameTB
            // 
            this.MyNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceConfig, "my_name", true));
            this.MyNameTB.Location = new System.Drawing.Point(28, 46);
            this.MyNameTB.Name = "MyNameTB";
            this.MyNameTB.Size = new System.Drawing.Size(197, 20);
            this.MyNameTB.TabIndex = 0;
            // 
            // SystemNameLbl
            // 
            this.SystemNameLbl.AutoSize = true;
            this.SystemNameLbl.Location = new System.Drawing.Point(304, 157);
            this.SystemNameLbl.Name = "SystemNameLbl";
            this.SystemNameLbl.Size = new System.Drawing.Size(81, 13);
            this.SystemNameLbl.TabIndex = 18;
            this.SystemNameLbl.Text = "Nazwa systemu";
            // 
            // SystemNameTB
            // 
            this.SystemNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceConfig, "system_name", true));
            this.SystemNameTB.Location = new System.Drawing.Point(307, 183);
            this.SystemNameTB.Name = "SystemNameTB";
            this.SystemNameTB.Size = new System.Drawing.Size(197, 20);
            this.SystemNameTB.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(789, 435);
            this.Controls.Add(this.MainFormTabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generator JPK";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.MainFormTabControl.ResumeLayout(false);
            this.InvoicesTab.ResumeLayout(false);
            this.JpkTab.ResumeLayout(false);
            this.JpkTab.PerformLayout();
            this.ConfigTab.ResumeLayout(false);
            this.ConfigTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceConfig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountnetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountvatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractornipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofissueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofsaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddNewBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TabControl MainFormTabControl;
        private System.Windows.Forms.TabPage InvoicesTab;
        private System.Windows.Forms.TabPage JpkTab;
        private System.Windows.Forms.TabPage ConfigTab;
        private System.Windows.Forms.Label MyNameLbl;
        private System.Windows.Forms.TextBox MyNameTB;
        private System.Windows.Forms.BindingSource bindingSourceConfig;
        private System.Windows.Forms.Label FormVariantLbl;
        private System.Windows.Forms.Label PurposeOfSubmissionLbl;
        private System.Windows.Forms.TextBox PurposeOfSubmissionTB;
        private System.Windows.Forms.Label MyEmailLbl;
        private System.Windows.Forms.TextBox MyEmailTB;
        private System.Windows.Forms.Label MyNipLbl;
        private System.Windows.Forms.TextBox MyNipTB;
        private System.Windows.Forms.Label MyAddressLbl;
        private System.Windows.Forms.TextBox MyAddressTB;
        private System.Windows.Forms.Button SaveConfigBtn;
        private System.Windows.Forms.TextBox FormVariantTB;
        private System.Windows.Forms.Label PathForJpkLbl;
        private System.Windows.Forms.TextBox PathForJpkTB;
        private System.Windows.Forms.Button GenerateJpkBtn;
        private System.Windows.Forms.Label DateToLbl;
        private System.Windows.Forms.TextBox DateToTB;
        private System.Windows.Forms.Label DateFromLbl;
        private System.Windows.Forms.TextBox DateFromTB;
        private System.Windows.Forms.Label SystemNameLbl;
        private System.Windows.Forms.TextBox SystemNameTB;
    }
}

