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
            //bindingSource.ResetBindings(false);
        }



        

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
                controller.ShowEditForm(bindingSource);
        }
    }
}
