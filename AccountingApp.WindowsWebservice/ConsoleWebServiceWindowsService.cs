using AccountingApp.Helpers;
using System.ServiceModel;
using System.ServiceProcess;

namespace AccountingApp.WindowsWebservice
{
    public partial class ConsoleWebServiceWindowsService : ServiceBase
    {
        public ServiceHost serviceHost = null;
        public ConsoleWebServiceWindowsService()
        {
            ServiceName = "AccountingApp Service";
        }

        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            serviceHost = new ServiceHost(typeof(ConsoleWebService));
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}