using AccountingApp.Controllers;
using AccountingApp.Forms;
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

namespace AccountingApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            SetController();
            InitializeComponent();
        }

        public event Action<object, MainForm> OnDelete;

        public delegate void SaveConfigEvent(object entity, MainForm dlg);

        public event SaveConfigEvent OnSaveConfig;

        public delegate void GenerateJpkEvent(DateTime dateFrom, DateTime dateTo, MainForm dlg);

        public event GenerateJpkEvent OnGenerateJpk;

        public void SetDataSource(object data)
        {
            //todo pusta lista
            if (data != null)
                bindingSource.DataSource = data;
        }

        public void SetConfigDataSource(object data)
        {
                bindingSourceConfig.DataSource = data != null ? data : new config();
        }

        private MainFormController controller { get; set; }

        public void SetController()
        {
            controller = new MainFormController(this);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (controller != null)
            {
                invoice invoice = bindingSource.Current as invoice;
                if (invoice == null)
                {
                    MessageBox.Show("Zaznacz rekord do edycji", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                controller.ShowEditForm(invoice);
            }
        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            if (controller != null)
            {
                invoice invoice = new invoice();
                controller.ShowEditForm(invoice);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            OnDelete?.Invoke(bindingSource.Current, this);
        }

        private void SaveConfigBtn_Click(object sender, EventArgs e)
        {
            OnSaveConfig?.Invoke(bindingSourceConfig.Current, this);
        }

        private void GenerateJpkBtn_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = Convert.ToDateTime(DateFromTB.Text);
            DateTime dateTo = Convert.ToDateTime(DateToTB.Text);
            OnGenerateJpk?.Invoke(dateFrom, dateTo, this);
        }

        private void ForMonthDTP_ValueChanged(object sender, EventArgs e)
        {
            var date = ForMonthDTP.Value;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            DateFromTB.Text = firstDayOfMonth.ToString("yyyy-MM-dd");
            DateToTB.Text = lastDayOfMonth.ToString("yyyy-MM-dd");
        }
    }
}
