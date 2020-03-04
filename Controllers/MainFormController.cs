using JPK_generator.Dao;
using JPK_generator.Forms;
using JPK_generator.Model;
using JPK_generator.XSD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPK_generator.Controllers
{
    class MainFormController
    {

        private MainForm View { get; set; }

        private MainFormDao Dao { get; set; }

        public MainFormController(MainForm view)
        {
            View = view;
            Dao = new MainFormDao();
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
            var configData = FetchConfigData();
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
            invoice invoice = entity == null ? new invoice() : entity as invoice;
            if (invoice.invoice_id == 0)
            {
                Dao.SaveNew(invoice);
                RefreshView(View);
            }
            else Dao.Save(invoice);
        }

        public void dlg_OnDelete(object entity, MainForm view)
        {
            if (entity == null)
                MessageBox.Show("Zaznacz rekord do usunięcia", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            invoice invoice = entity as invoice;
            string message = "Czy jesteś pewien?";
            string title = "Potwierdzenie usunięcia faktury";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Dao.Delete(invoice);
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
            Dao.SaveConfig(config);
        }

        public void dlg_OnGenerateJpk(DateTime dateFrom, DateTime dateTo, MainForm view)
        {
            if (dateFrom > dateTo)
                MessageBox.Show("Data do nie może być późniejsza niż data do", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            JpkGenerator generator = new JpkGenerator();
            IList<invoice> invoices = GetInvoicesListForJpk(dateFrom, dateTo);
            generator.GenerateJpk(invoices, dateFrom, dateTo);

                
        }

        public IList<invoice> FetchList()
        {
            return Dao.GetInvoices();
        }

        public config FetchConfigData()
        {
            return Dao.GetConfigData();
        }

        public IList<invoice> GetInvoicesListForJpk(DateTime dateFrom, DateTime dateTo)
        {
            return Dao.GetInvoicesListForJpk(dateFrom, dateTo);
        }




    }
}
