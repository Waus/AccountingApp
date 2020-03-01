using JPK_generator.Dao;
using JPK_generator.Forms;
using JPK_generator.Model;
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
            dlg.Close();
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

        public IList<invoice> FetchList()
        {
            return Dao.GetInvoices();
        }

        //public invoice GetInvoiceForEdit()
        //{
        //    return Dao.GetInvoice();
        //}



    }
}
