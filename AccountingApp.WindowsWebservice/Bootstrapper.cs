using Autofac;
using AccountingApp.Logic;

namespace AccountingApp.WindowsWebservice
{
    public class Bootstrapper
    {
        public static ContainerBuilder RegisterContainerBuilder()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.Register(c => new ConfigOperations()).As<IConfigOperations>();
            builder.Register(c => new InvoiceOperations()).As<IInvoiceOperations>();
            builder.Register(c => new ConsoleWebService(c.Resolve<IConfigOperations>(), c.Resolve<IInvoiceOperations>())).As<IConsoleWebService>();
            return builder;
        }
    }
}
