using AccountingApp.Helpers;
using System;
using System.ServiceProcess;
using System.Windows.Forms;

namespace AccountingApp.WindowsWebservice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            try
            {
                ConnectionStrings.PrepareConnectionString("AccountingAppEntities");

                ServiceBase.Run(new ConsoleWebServiceWindowsService());
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
