using AccountingApp.Controllers;
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
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                MainForm view = new MainForm();
                view.Visible = false;

                MainFormController controller = new MainFormController(view);
                controller.PrepareView(view);
                controller.PrepareConfigTab(view);
                Application.Run(view);
            }
            catch (Exception e)
            {
                MessageBox.Show("Wystąpił błąd i aplikacja zostanie zamknięta. " 
                    + e.Message + "," + e.StackTrace 
                    + ((e.InnerException != null) ? e.InnerException.Message + e.InnerException.StackTrace : ""));
            }
        }
    }
}
