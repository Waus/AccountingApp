using AccountingApp.Controllers;
using AccountingApp.Helpers;
using System;
using System.Windows.Forms;

namespace AccountingApp.Console
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConnectionStrings.PrepareConnectionString("AccountingAppEntities");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm view = new MainForm();
            view.Visible = false;

            MainFormController controller = new MainFormController(view);
            controller.PrepareView(view);
            controller.PrepareConfigTab(view);
            Application.Run(view);
            //Application.Run(new MainForm());
        }
    }
}
