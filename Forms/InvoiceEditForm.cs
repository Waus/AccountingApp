using AccountingApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp.Forms
{
    public partial class InvoiceEditForm : Form
    {
        public delegate void SaveFormEvent(object entity, InvoiceEditForm dlg);

        public event SaveFormEvent OnSave;

        public InvoiceEditForm()
        {
            InitializeComponent();
        }

        public void SetDataSource(object data)
        {
            bindingSource.DataSource = data;
        }

        private void SaveAndExitBtn_Click(object sender, EventArgs e)
        {
            OnSave?.Invoke(bindingSource.Current, this);
            Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            OnSave?.Invoke(bindingSource.Current, this);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
