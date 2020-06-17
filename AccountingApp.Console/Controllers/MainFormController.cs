using AccountingApp.Dao;
using AccountingApp.EF;
using AccountingApp.Forms;
using AccountingApp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AccountingApp.Controllers
{
    class MainFormController
    {

        private MainForm View { get; set; }

        private IInvoiceDao InvoiceDao { get; set; }

        private IConfigDao ConfigDao { get; set; }

        public MainFormController(MainForm view)
        {
            View = view;
            InvoiceDao = new InvoiceDao();
            ConfigDao = new ConfigDao();
        }

        public void PrepareView(MainForm view)
        {
            var list = FetchList();
            AddEvents(view);
            view.SetDataSource(list);
            view.SetController();
        }

        public void PrepareConfigTab(MainForm view)
        {
            config configData = GetConfigData();
            view.SetConfigDataSource(configData);
        }

        public void RefreshView(MainForm view)
        {
            var list = FetchList();
            view.SetDataSource(list);
        }

        public void ShowEditForm(invoice invoice)
        {
            InvoiceEditForm dlg = new InvoiceEditForm();
            AddEvents(invoice, dlg);
            dlg.SetDataSource(invoice);
            dlg.ShowDialog();
        }

        public void AddEvents(object entity, InvoiceEditForm dlg)
        {
            dlg.OnSave += dlg_OnSave;
        }

        public void AddEvents(MainForm view)
        {
            view.OnDelete += new Action<object, MainForm>(dlg_OnDelete);
            view.OnSaveConfig += dlg_OnSaveConfig;
            view.OnGenerateJpk += dlg_OnGenerateJpk;
        }

        public void dlg_OnSave(object entity, InvoiceEditForm dlg)
        {
            invoice invoice = entity as invoice ?? new invoice();
            if (invoice.date_added == null)
                invoice.date_added = DateTime.Now;
            if (invoice.invoice_id == 0)
            {
                InvoiceDao.Save(invoice);
                RefreshView(View);
            }
            else InvoiceDao.Save(invoice);
        }

        public void dlg_OnDelete(object entity, MainForm view)
        {
            if (entity == null)
            {
                MessageBox.Show("Zaznacz rekord do usunięcia", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            invoice invoice = entity as invoice;
            string message = "Czy jesteś pewien?";
            string title = "Potwierdzenie usunięcia faktury";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                InvoiceDao.Delete(invoice);
                RefreshView(view);
            }
            else
            {
                return;
            }
        }

        public void dlg_OnSaveConfig(object entity, MainForm view)
        {
            config config = entity as config;
            ConfigDao.Save(config);
        }

        public void dlg_OnGenerateJpk(DateTime dateFrom, DateTime dateTo, MainForm view)
        {
            if (dateFrom > dateTo)
                MessageBox.Show("Data do nie może być późniejsza niż data od", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            JpkGenerator generator = new JpkGenerator();
            IList<invoice> invoices = FetchListForJpk(dateFrom, dateTo);
            config config = GetConfigData();
            generator.GenerateJpk(invoices, config, dateFrom, dateTo);     
        }

        public IList<invoice> FetchList()
        {
            return InvoiceDao.FetchList();
        }

        public IList<invoice> FetchListForJpk(DateTime dateFrom, DateTime dateTo)
        {
            return InvoiceDao.FetchListForJpk(dateFrom, dateTo);
        }

        public config GetConfigData()
        {
            return ConfigDao.Get(1);
        }


    }
}
