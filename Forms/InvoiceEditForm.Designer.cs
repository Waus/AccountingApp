namespace AccountingApp.Forms
{
    partial class InvoiceEditForm
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
            this.InvoiceNumberLbl = new System.Windows.Forms.Label();
            this.InvoiceNumberTB = new System.Windows.Forms.TextBox();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.NetAmountTB = new System.Windows.Forms.TextBox();
            this.NetAmountLbl = new System.Windows.Forms.Label();
            this.VatAmountTB = new System.Windows.Forms.TextBox();
            this.VatAmountLbl = new System.Windows.Forms.Label();
            this.ContractorAddressTB = new System.Windows.Forms.TextBox();
            this.ContractorAddressLbl = new System.Windows.Forms.Label();
            this.ContractorNameTB = new System.Windows.Forms.TextBox();
            this.ContractorNameLbl = new System.Windows.Forms.Label();
            this.VatRateTB = new System.Windows.Forms.TextBox();
            this.VatRateLbl = new System.Windows.Forms.Label();
            this.DateOfSaleLbl = new System.Windows.Forms.Label();
            this.DateOfIssueLbl = new System.Windows.Forms.Label();
            this.ContractorNipTB = new System.Windows.Forms.TextBox();
            this.ContractorNipLbl = new System.Windows.Forms.Label();
            this.IncomeCB = new System.Windows.Forms.CheckBox();
            this.SaveAndExitBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.DateOfIssueDTP = new System.Windows.Forms.DateTimePicker();
            this.DateOfSaleDTP = new System.Windows.Forms.DateTimePicker();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoiceNumberLbl
            // 
            this.InvoiceNumberLbl.AutoSize = true;
            this.InvoiceNumberLbl.Location = new System.Drawing.Point(45, 33);
            this.InvoiceNumberLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InvoiceNumberLbl.Name = "InvoiceNumberLbl";
            this.InvoiceNumberLbl.Size = new System.Drawing.Size(97, 17);
            this.InvoiceNumberLbl.TabIndex = 0;
            this.InvoiceNumberLbl.Text = "Numer faktury";
            // 
            // InvoiceNumberTB
            // 
            this.InvoiceNumberTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "invoice_number", true));
            this.InvoiceNumberTB.Location = new System.Drawing.Point(49, 64);
            this.InvoiceNumberTB.Margin = new System.Windows.Forms.Padding(4);
            this.InvoiceNumberTB.Name = "InvoiceNumberTB";
            this.InvoiceNumberTB.Size = new System.Drawing.Size(239, 22);
            this.InvoiceNumberTB.TabIndex = 1;
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "description", true));
            this.DescriptionTB.Location = new System.Drawing.Point(49, 442);
            this.DescriptionTB.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(775, 22);
            this.DescriptionTB.TabIndex = 3;
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(45, 411);
            this.DescriptionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(37, 17);
            this.DescriptionLbl.TabIndex = 2;
            this.DescriptionLbl.Text = "Opis";
            // 
            // NetAmountTB
            // 
            this.NetAmountTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "amount_net", true));
            this.NetAmountTB.Location = new System.Drawing.Point(585, 160);
            this.NetAmountTB.Margin = new System.Windows.Forms.Padding(4);
            this.NetAmountTB.Name = "NetAmountTB";
            this.NetAmountTB.Size = new System.Drawing.Size(239, 22);
            this.NetAmountTB.TabIndex = 5;
            // 
            // NetAmountLbl
            // 
            this.NetAmountLbl.AutoSize = true;
            this.NetAmountLbl.Location = new System.Drawing.Point(581, 129);
            this.NetAmountLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NetAmountLbl.Name = "NetAmountLbl";
            this.NetAmountLbl.Size = new System.Drawing.Size(82, 17);
            this.NetAmountLbl.TabIndex = 4;
            this.NetAmountLbl.Text = "Kwota netto";
            // 
            // VatAmountTB
            // 
            this.VatAmountTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "amount_vat", true));
            this.VatAmountTB.Location = new System.Drawing.Point(585, 256);
            this.VatAmountTB.Margin = new System.Windows.Forms.Padding(4);
            this.VatAmountTB.Name = "VatAmountTB";
            this.VatAmountTB.Size = new System.Drawing.Size(239, 22);
            this.VatAmountTB.TabIndex = 7;
            // 
            // VatAmountLbl
            // 
            this.VatAmountLbl.AutoSize = true;
            this.VatAmountLbl.Location = new System.Drawing.Point(581, 225);
            this.VatAmountLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VatAmountLbl.Name = "VatAmountLbl";
            this.VatAmountLbl.Size = new System.Drawing.Size(77, 17);
            this.VatAmountLbl.TabIndex = 6;
            this.VatAmountLbl.Text = "Kwota VAT";
            // 
            // ContractorAddressTB
            // 
            this.ContractorAddressTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "contractor_address", true));
            this.ContractorAddressTB.Location = new System.Drawing.Point(317, 256);
            this.ContractorAddressTB.Margin = new System.Windows.Forms.Padding(4);
            this.ContractorAddressTB.Name = "ContractorAddressTB";
            this.ContractorAddressTB.Size = new System.Drawing.Size(239, 22);
            this.ContractorAddressTB.TabIndex = 13;
            // 
            // ContractorAddressLbl
            // 
            this.ContractorAddressLbl.AutoSize = true;
            this.ContractorAddressLbl.Location = new System.Drawing.Point(313, 225);
            this.ContractorAddressLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContractorAddressLbl.Name = "ContractorAddressLbl";
            this.ContractorAddressLbl.Size = new System.Drawing.Size(125, 17);
            this.ContractorAddressLbl.TabIndex = 12;
            this.ContractorAddressLbl.Text = "Adres kontrahenta";
            // 
            // ContractorNameTB
            // 
            this.ContractorNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "contractor_name", true));
            this.ContractorNameTB.Location = new System.Drawing.Point(317, 160);
            this.ContractorNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.ContractorNameTB.Name = "ContractorNameTB";
            this.ContractorNameTB.Size = new System.Drawing.Size(239, 22);
            this.ContractorNameTB.TabIndex = 11;
            // 
            // ContractorNameLbl
            // 
            this.ContractorNameLbl.AutoSize = true;
            this.ContractorNameLbl.Location = new System.Drawing.Point(313, 129);
            this.ContractorNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContractorNameLbl.Name = "ContractorNameLbl";
            this.ContractorNameLbl.Size = new System.Drawing.Size(130, 17);
            this.ContractorNameLbl.TabIndex = 10;
            this.ContractorNameLbl.Text = "Nazwa kontrahenta";
            // 
            // VatRateTB
            // 
            this.VatRateTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "vat_rate", true));
            this.VatRateTB.Location = new System.Drawing.Point(585, 64);
            this.VatRateTB.Margin = new System.Windows.Forms.Padding(4);
            this.VatRateTB.Name = "VatRateTB";
            this.VatRateTB.Size = new System.Drawing.Size(239, 22);
            this.VatRateTB.TabIndex = 9;
            // 
            // VatRateLbl
            // 
            this.VatRateLbl.AutoSize = true;
            this.VatRateLbl.Location = new System.Drawing.Point(581, 33);
            this.VatRateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VatRateLbl.Name = "VatRateLbl";
            this.VatRateLbl.Size = new System.Drawing.Size(84, 17);
            this.VatRateLbl.TabIndex = 8;
            this.VatRateLbl.Text = "Stawka VAT";
            // 
            // DateOfSaleLbl
            // 
            this.DateOfSaleLbl.AutoSize = true;
            this.DateOfSaleLbl.Location = new System.Drawing.Point(48, 225);
            this.DateOfSaleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateOfSaleLbl.Name = "DateOfSaleLbl";
            this.DateOfSaleLbl.Size = new System.Drawing.Size(209, 17);
            this.DateOfSaleLbl.TabIndex = 22;
            this.DateOfSaleLbl.Text = "Data sprzedaży (YYYY-MM-DD)";
            // 
            // DateOfIssueLbl
            // 
            this.DateOfIssueLbl.AutoSize = true;
            this.DateOfIssueLbl.Location = new System.Drawing.Point(48, 129);
            this.DateOfIssueLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateOfIssueLbl.Name = "DateOfIssueLbl";
            this.DateOfIssueLbl.Size = new System.Drawing.Size(218, 17);
            this.DateOfIssueLbl.TabIndex = 20;
            this.DateOfIssueLbl.Text = "Data wystawienia (YYYY-MM-DD)";
            // 
            // ContractorNipTB
            // 
            this.ContractorNipTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "contractor_nip", true));
            this.ContractorNipTB.Location = new System.Drawing.Point(317, 64);
            this.ContractorNipTB.Margin = new System.Windows.Forms.Padding(4);
            this.ContractorNipTB.Name = "ContractorNipTB";
            this.ContractorNipTB.Size = new System.Drawing.Size(239, 22);
            this.ContractorNipTB.TabIndex = 17;
            // 
            // ContractorNipLbl
            // 
            this.ContractorNipLbl.AutoSize = true;
            this.ContractorNipLbl.Location = new System.Drawing.Point(313, 33);
            this.ContractorNipLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContractorNipLbl.Name = "ContractorNipLbl";
            this.ContractorNipLbl.Size = new System.Drawing.Size(110, 17);
            this.ContractorNipLbl.TabIndex = 16;
            this.ContractorNipLbl.Text = "NIP kontrahenta";
            // 
            // IncomeCB
            // 
            this.IncomeCB.AutoSize = true;
            this.IncomeCB.Checked = true;
            this.IncomeCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncomeCB.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "income", true));
            this.IncomeCB.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bindingSource, "income", true));
            this.IncomeCB.Location = new System.Drawing.Point(49, 352);
            this.IncomeCB.Margin = new System.Windows.Forms.Padding(4);
            this.IncomeCB.Name = "IncomeCB";
            this.IncomeCB.Size = new System.Drawing.Size(147, 21);
            this.IncomeCB.TabIndex = 24;
            this.IncomeCB.Text = "Faktura sprzedaży";
            this.IncomeCB.UseVisualStyleBackColor = true;
            // 
            // SaveAndExitBtn
            // 
            this.SaveAndExitBtn.Location = new System.Drawing.Point(899, 64);
            this.SaveAndExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveAndExitBtn.Name = "SaveAndExitBtn";
            this.SaveAndExitBtn.Size = new System.Drawing.Size(155, 28);
            this.SaveAndExitBtn.TabIndex = 25;
            this.SaveAndExitBtn.Text = "Zapisz i zakończ";
            this.SaveAndExitBtn.UseVisualStyleBackColor = true;
            this.SaveAndExitBtn.Click += new System.EventHandler(this.SaveAndExitBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(899, 250);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(155, 28);
            this.CancelBtn.TabIndex = 26;
            this.CancelBtn.Text = "Zaniechaj";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // DateOfIssueDTP
            // 
            this.DateOfIssueDTP.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "date_of_issue", true));
            this.DateOfIssueDTP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "date_of_issue", true));
            this.DateOfIssueDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfIssueDTP.Location = new System.Drawing.Point(52, 160);
            this.DateOfIssueDTP.Name = "DateOfIssueDTP";
            this.DateOfIssueDTP.Size = new System.Drawing.Size(236, 22);
            this.DateOfIssueDTP.TabIndex = 27;
            // 
            // DateOfSaleDTP
            // 
            this.DateOfSaleDTP.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "date_of_sale", true));
            this.DateOfSaleDTP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "date_of_sale", true));
            this.DateOfSaleDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfSaleDTP.Location = new System.Drawing.Point(52, 256);
            this.DateOfSaleDTP.Name = "DateOfSaleDTP";
            this.DateOfSaleDTP.Size = new System.Drawing.Size(236, 22);
            this.DateOfSaleDTP.TabIndex = 28;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(899, 160);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(155, 28);
            this.SaveBtn.TabIndex = 29;
            this.SaveBtn.Text = "Zapisz";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(AccountingApp.Model.invoice);
            // 
            // InvoiceEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DateOfSaleDTP);
            this.Controls.Add(this.DateOfIssueDTP);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveAndExitBtn);
            this.Controls.Add(this.IncomeCB);
            this.Controls.Add(this.DateOfSaleLbl);
            this.Controls.Add(this.DateOfIssueLbl);
            this.Controls.Add(this.ContractorNipTB);
            this.Controls.Add(this.ContractorNipLbl);
            this.Controls.Add(this.ContractorAddressTB);
            this.Controls.Add(this.ContractorAddressLbl);
            this.Controls.Add(this.ContractorNameTB);
            this.Controls.Add(this.ContractorNameLbl);
            this.Controls.Add(this.VatRateTB);
            this.Controls.Add(this.VatRateLbl);
            this.Controls.Add(this.VatAmountTB);
            this.Controls.Add(this.VatAmountLbl);
            this.Controls.Add(this.NetAmountTB);
            this.Controls.Add(this.NetAmountLbl);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.InvoiceNumberTB);
            this.Controls.Add(this.InvoiceNumberLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InvoiceEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dane faktury";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InvoiceNumberLbl;
        private System.Windows.Forms.TextBox InvoiceNumberTB;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.TextBox NetAmountTB;
        private System.Windows.Forms.Label NetAmountLbl;
        private System.Windows.Forms.TextBox VatAmountTB;
        private System.Windows.Forms.Label VatAmountLbl;
        private System.Windows.Forms.TextBox ContractorAddressTB;
        private System.Windows.Forms.Label ContractorAddressLbl;
        private System.Windows.Forms.TextBox ContractorNameTB;
        private System.Windows.Forms.Label ContractorNameLbl;
        private System.Windows.Forms.TextBox VatRateTB;
        private System.Windows.Forms.Label VatRateLbl;
        private System.Windows.Forms.Label DateOfSaleLbl;
        private System.Windows.Forms.Label DateOfIssueLbl;
        private System.Windows.Forms.TextBox ContractorNipTB;
        private System.Windows.Forms.Label ContractorNipLbl;
        private System.Windows.Forms.CheckBox IncomeCB;
        private System.Windows.Forms.Button SaveAndExitBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.DateTimePicker DateOfIssueDTP;
        private System.Windows.Forms.DateTimePicker DateOfSaleDTP;
        private System.Windows.Forms.Button SaveBtn;
    }
}