using Autofac;
using AccountingApp.Logic;
using AccountingApp.Dao;
using AccountingApp.Dao.EF;

namespace AccountingApp.WindowsWebservice
{
    public class Bootstrapper
    {
        public static ContainerBuilder RegisterContainerBuilder()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.Register(c => new ConfigDao()).As<IConfigDao>();
            builder.Register(c => new InvoiceDao()).As<IInvoiceDao>();
            builder.Register(c => new ConfigOperations(c.Resolve<IConfigDao>()));
            builder.Register(c => new InvoiceOperations(c.Resolve<IInvoiceDao>()));
            builder.Register(c => new ConsoleWebService(c.Resolve<ConfigOperations>(), c.Resolve<InvoiceOperations>())).As<IConsoleWebService>();
            return builder;
        }
    }
}
