using JPK_generator.Controllers;
using JPK_generator.Forms;
using JPK_generator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPK_generator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            SetController();
            InitializeComponent();
        }

        public event Action<object, MainForm> OnDelete;



        public void SetDataSource(object data)
        {
            bindingSource.DataSource = data;
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
            if (OnDelete != null)
                OnDelete(bindingSource.Current, this);
        }
    }
}
