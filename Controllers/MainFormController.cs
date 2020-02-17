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
            view.SetDataSource(list);
            view.SetController();
        }

        public void ShowEditForm(BindingSource dataSource)
        {
            invoice invoice = dataSource.Current as invoice;
            InvoiceEditForm dlg = new InvoiceEditForm();
            AddEvents(invoice, dlg);
            dlg.SetDataSource(invoice);
            dlg.ShowDialog();
        }

        public void AddEvents(object entity, InvoiceEditForm dlg)
        {
            dlg.OnSave += dlg_OnSave;
            //dlg.OnSave += new BaseEditDlg.ControlledFormSaveEvent(dlg_OnSave);
        }

        public void dlg_OnSave(object entity, InvoiceEditForm dlg)
        {
            invoice invoice = entity as invoice;
            Dao.Save(invoice);
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
