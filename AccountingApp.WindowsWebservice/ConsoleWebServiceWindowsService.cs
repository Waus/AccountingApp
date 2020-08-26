using Autofac;
using Autofac.Core;
using Autofac.Integration.Wcf;
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

            IContainer container = Bootstrapper.RegisterContainerBuilder().Build();
            serviceHost = new ServiceHost(typeof(ConsoleWebService));

            IComponentRegistration registration;
            if (!container.ComponentRegistry.TryGetRegistration(new TypedService(typeof(IConsoleWebService)), out registration))
            {
                //Environment.Exit(-1);
            }

            serviceHost.AddDependencyInjectionBehavior<IConsoleWebService>(container);
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