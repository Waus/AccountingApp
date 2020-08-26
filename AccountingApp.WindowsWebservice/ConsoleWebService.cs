using AccountingApp.Logic;
using AccountingApp.Model;
using System;
using System.Collections.Generic;

namespace AccountingApp.WindowsWebservice
{
    public class ConsoleWebService : IConsoleWebService
    {
        private readonly IConfigOperations ConfigOperations;
        private readonly IInvoiceOperations InvoiceOperations;

        public ConsoleWebService(IConfigOperations configOperations, IInvoiceOperations invoiceOperations)
        {
            ConfigOperations = configOperations;
            InvoiceOperations = invoiceOperations;
        }

        //class without default constructor can't be serialized.
        public ConsoleWebService()
        {
        }

        public void SaveConfig(config config)
        {
            ConfigOperations.SaveConfig(config);
        }

        public config GetConfig()
        {
            return ConfigOperations.GetConfig();
        }

        public void SaveInvoice(invoice invoice)
        {
            InvoiceOperations.SaveInvoice(invoice);
        }

        public void DeleteInvoice(invoice invoice)
        {
            InvoiceOperations.DeleteInvoice(invoice);
        }

        public IList<invoice> GetInvoiceData()
        {
            return InvoiceOperations.GetInvoiceData();
        }

        //public invoice GetInvoice(int invoiceId)
        //{
        //    return InvoiceOperations.GetInvoice(invoiceId);
        //}

        public IList<invoice> FetchListForJpk(DateTime dateFrom, DateTime dateTo)
        {
            return InvoiceOperations.FetchListForJpk(dateFrom, dateTo);
        }
    }
}
