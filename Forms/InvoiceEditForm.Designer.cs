namespace JPK_generator.Forms
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
            this.ContractorAddress2TB = new System.Windows.Forms.TextBox();
            this.ContractorAddress2Lbl = new System.Windows.Forms.Label();
            this.ContractorAddress1TB = new System.Windows.Forms.TextBox();
            this.ContractorAddress1Lbl = new System.Windows.Forms.Label();
            this.ContractorNameTB = new System.Windows.Forms.TextBox();
            this.ContractorNameLbl = new System.Windows.Forms.Label();
            this.VatRateTB = new System.Windows.Forms.TextBox();
            this.VatRateLbl = new System.Windows.Forms.Label();
            this.DateOfSaleTB = new System.Windows.Forms.TextBox();
            this.DateOfSaleLbl = new System.Windows.Forms.Label();
            this.DateOfIssueLbl = new System.Windows.Forms.Label();
            this.ContractorNipTB = new System.Windows.Forms.TextBox();
            this.ContractorNipLbl = new System.Windows.Forms.Label();
            this.DateOfIssueTB = new System.Windows.Forms.TextBox();
            this.IncomeCB = new System.Windows.Forms.CheckBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoiceNumberLbl
            // 
            this.InvoiceNumberLbl.AutoSize = true;
            this.InvoiceNumberLbl.Location = new System.Drawing.Point(34, 27);
            this.InvoiceNumberLbl.Name = "InvoiceNumberLbl";
            this.InvoiceNumberLbl.Size = new System.Drawing.Size(73, 13);
            this.InvoiceNumberLbl.TabIndex = 0;
            this.InvoiceNumberLbl.Text = "Numer faktury";
            // 
            // InvoiceNumberTB
            // 
            this.InvoiceNumberTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "invoice_number", true));
            this.InvoiceNumberTB.Location = new System.Drawing.Point(37, 52);
            this.InvoiceNumberTB.Name = "InvoiceNumberTB";
            this.InvoiceNumberTB.Size = new System.Drawing.Size(180, 20);
            this.InvoiceNumberTB.TabIndex = 1;
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "description", true));
            this.DescriptionTB.Location = new System.Drawing.Point(37, 359);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(582, 20);
            this.DescriptionTB.TabIndex = 3;
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(34, 334);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(28, 13);
            this.DescriptionLbl.TabIndex = 2;
            this.DescriptionLbl.Text = "Opis";
            // 
            // NetAmountTB
            // 
            this.NetAmountTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "amount_net", true));
            this.NetAmountTB.Location = new System.Drawing.Point(439, 130);
            this.NetAmountTB.Name = "NetAmountTB";
            this.NetAmountTB.Size = new System.Drawing.Size(180, 20);
            this.NetAmountTB.TabIndex = 5;
            // 
            // NetAmountLbl
            // 
            this.NetAmountLbl.AutoSize = true;
            this.NetAmountLbl.Location = new System.Drawing.Point(436, 105);
            this.NetAmountLbl.Name = "NetAmountLbl";
            this.NetAmountLbl.Size = new System.Drawing.Size(64, 13);
            this.NetAmountLbl.TabIndex = 4;
            this.NetAmountLbl.Text = "Kwota netto";
            // 
            // VatAmountTB
            // 
            this.VatAmountTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "amount_vat", true));
            this.VatAmountTB.Location = new System.Drawing.Point(439, 208);
            this.VatAmountTB.Name = "VatAmountTB";
            this.VatAmountTB.Size = new System.Drawing.Size(180, 20);
            this.VatAmountTB.TabIndex = 7;
            // 
            // VatAmountLbl
            // 
            this.VatAmountLbl.AutoSize = true;
            this.VatAmountLbl.Location = new System.Drawing.Point(436, 183);
            this.VatAmountLbl.Name = "VatAmountLbl";
            this.VatAmountLbl.Size = new System.Drawing.Size(61, 13);
            this.VatAmountLbl.TabIndex = 6;
            this.VatAmountLbl.Text = "Kwota VAT";
            // 
            // ContractorAddress2TB
            // 
            this.ContractorAddress2TB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "contractor_address2", true));
            this.ContractorAddress2TB.Location = new System.Drawing.Point(238, 289);
            this.ContractorAddress2TB.Name = "ContractorAddress2TB";
            this.ContractorAddress2TB.Size = new System.Drawing.Size(180, 20);
            this.ContractorAddress2TB.TabIndex = 15;
            // 
            // ContractorAddress2Lbl
            // 
            this.ContractorAddress2Lbl.AutoSize = true;
            this.ContractorAddress2Lbl.Location = new System.Drawing.Point(235, 264);
            this.ContractorAddress2Lbl.Name = "ContractorAddress2Lbl";
            this.ContractorAddress2Lbl.Size = new System.Drawing.Size(103, 13);
            this.ContractorAddress2Lbl.TabIndex = 14;
            this.ContractorAddress2Lbl.Text = "Adres kontrahenta 2";
            // 
            // ContractorAddress1TB
            // 
            this.ContractorAddress1TB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "contractor_address1", true));
            this.ContractorAddress1TB.Location = new System.Drawing.Point(238, 208);
            this.ContractorAddress1TB.Name = "ContractorAddress1TB";
            this.ContractorAddress1TB.Size = new System.Drawing.Size(180, 20);
            this.ContractorAddress1TB.TabIndex = 13;
            // 
            // ContractorAddress1Lbl
            // 
            this.ContractorAddress1Lbl.AutoSize = true;
            this.ContractorAddress1Lbl.Location = new System.Drawing.Point(235, 183);
            this.ContractorAddress1Lbl.Name = "ContractorAddress1Lbl";
            this.ContractorAddress1Lbl.Size = new System.Drawing.Size(103, 13);
            this.ContractorAddress1Lbl.TabIndex = 12;
            this.ContractorAddress1Lbl.Text = "Adres kontrahenta 1";
            // 
            // ContractorNameTB
            // 
            this.ContractorNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "contractor_name", true));
            this.ContractorNameTB.Location = new System.Drawing.Point(238, 130);
            this.ContractorNameTB.Name = "ContractorNameTB";
            this.ContractorNameTB.Size = new System.Drawing.Size(180, 20);
            this.ContractorNameTB.TabIndex = 11;
            // 
            // ContractorNameLbl
            // 
            this.ContractorNameLbl.AutoSize = true;
            this.ContractorNameLbl.Location = new System.Drawing.Point(235, 105);
            this.ContractorNameLbl.Name = "ContractorNameLbl";
            this.ContractorNameLbl.Size = new System.Drawing.Size(100, 13);
            this.ContractorNameLbl.TabIndex = 10;
            this.ContractorNameLbl.Text = "Nazwa kontrahenta";
            // 
            // VatRateTB
            // 
            this.VatRateTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "vat_rate", true));
            this.VatRateTB.Location = new System.Drawing.Point(439, 52);
            this.VatRateTB.Name = "VatRateTB";
            this.VatRateTB.Size = new System.Drawing.Size(180, 20);
            this.VatRateTB.TabIndex = 9;
            // 
            // VatRateLbl
            // 
            this.VatRateLbl.AutoSize = true;
            this.VatRateLbl.Location = new System.Drawing.Point(436, 27);
            this.VatRateLbl.Name = "VatRateLbl";
            this.VatRateLbl.Size = new System.Drawing.Size(67, 13);
            this.VatRateLbl.TabIndex = 8;
            this.VatRateLbl.Text = "Stawka VAT";
            // 
            // DateOfSaleTB
            // 
            this.DateOfSaleTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "date_of_sale", true));
            this.DateOfSaleTB.Location = new System.Drawing.Point(39, 208);
            this.DateOfSaleTB.Name = "DateOfSaleTB";
            this.DateOfSaleTB.Size = new System.Drawing.Size(178, 20);
            this.DateOfSaleTB.TabIndex = 23;
            // 
            // DateOfSaleLbl
            // 
            this.DateOfSaleLbl.AutoSize = true;
            this.DateOfSaleLbl.Location = new System.Drawing.Point(36, 183);
            this.DateOfSaleLbl.Name = "DateOfSaleLbl";
            this.DateOfSaleLbl.Size = new System.Drawing.Size(167, 13);
            this.DateOfSaleLbl.TabIndex = 22;
            this.DateOfSaleLbl.Text = "Data wystawienia (YYYY-MM-DD)";
            // 
            // DateOfIssueLbl
            // 
            this.DateOfIssueLbl.AutoSize = true;
            this.DateOfIssueLbl.Location = new System.Drawing.Point(36, 105);
            this.DateOfIssueLbl.Name = "DateOfIssueLbl";
            this.DateOfIssueLbl.Size = new System.Drawing.Size(167, 13);
            this.DateOfIssueLbl.TabIndex = 20;
            this.DateOfIssueLbl.Text = "Data wystawienia (YYYY-MM-DD)";
            // 
            // ContractorNipTB
            // 
            this.ContractorNipTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "contractor_nip", true));
            this.ContractorNipTB.Location = new System.Drawing.Point(238, 52);
            this.ContractorNipTB.Name = "ContractorNipTB";
            this.ContractorNipTB.Size = new System.Drawing.Size(180, 20);
            this.ContractorNipTB.TabIndex = 17;
            // 
            // ContractorNipLbl
            // 
            this.ContractorNipLbl.AutoSize = true;
            this.ContractorNipLbl.Location = new System.Drawing.Point(235, 27);
            this.ContractorNipLbl.Name = "ContractorNipLbl";
            this.ContractorNipLbl.Size = new System.Drawing.Size(85, 13);
            this.ContractorNipLbl.TabIndex = 16;
            this.ContractorNipLbl.Text = "NIP kontrahenta";
            // 
            // DateOfIssueTB
            // 
            this.DateOfIssueTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "date_of_issue", true));
            this.DateOfIssueTB.Location = new System.Drawing.Point(39, 130);
            this.DateOfIssueTB.Name = "DateOfIssueTB";
            this.DateOfIssueTB.Size = new System.Drawing.Size(178, 20);
            this.DateOfIssueTB.TabIndex = 21;
            // 
            // IncomeCB
            // 
            this.IncomeCB.AutoSize = true;
            this.IncomeCB.Checked = true;
            this.IncomeCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncomeCB.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "income", true));
            this.IncomeCB.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bindingSource, "income", true));
            this.IncomeCB.Location = new System.Drawing.Point(37, 286);
            this.IncomeCB.Name = "IncomeCB";
            this.IncomeCB.Size = new System.Drawing.Size(112, 17);
            this.IncomeCB.TabIndex = 24;
            this.IncomeCB.Text = "Faktura sprzedaży";
            this.IncomeCB.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(674, 52);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 25;
            this.SaveBtn.Text = "Zapisz";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(674, 125);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 26;
            this.CancelBtn.Text = "Zaniechaj";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(JPK_generator.Model.invoice);
            // 
            // InvoiceEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.IncomeCB);
            this.Controls.Add(this.DateOfSaleTB);
            this.Controls.Add(this.DateOfSaleLbl);
            this.Controls.Add(this.DateOfIssueTB);
            this.Controls.Add(this.DateOfIssueLbl);
            this.Controls.Add(this.ContractorNipTB);
            this.Controls.Add(this.ContractorNipLbl);
            this.Controls.Add(this.ContractorAddress2TB);
            this.Controls.Add(this.ContractorAddress2Lbl);
            this.Controls.Add(this.ContractorAddress1TB);
            this.Controls.Add(this.ContractorAddress1Lbl);
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
            this.Name = "InvoiceEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox ContractorAddress2TB;
        private System.Windows.Forms.Label ContractorAddress2Lbl;
        private System.Windows.Forms.TextBox ContractorAddress1TB;
        private System.Windows.Forms.Label ContractorAddress1Lbl;
        private System.Windows.Forms.TextBox ContractorNameTB;
        private System.Windows.Forms.Label ContractorNameLbl;
        private System.Windows.Forms.TextBox VatRateTB;
        private System.Windows.Forms.Label VatRateLbl;
        private System.Windows.Forms.TextBox DateOfSaleTB;
        private System.Windows.Forms.Label DateOfSaleLbl;
        private System.Windows.Forms.Label DateOfIssueLbl;
        private System.Windows.Forms.TextBox ContractorNipTB;
        private System.Windows.Forms.Label ContractorNipLbl;
        private System.Windows.Forms.TextBox DateOfIssueTB;
        private System.Windows.Forms.CheckBox IncomeCB;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}