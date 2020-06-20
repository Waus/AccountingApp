using AccountingApp.Logic;
using AccountingApp.Model;
using System;
using System.Collections.Generic;

namespace AccountingApp.WCF
{
    public class ConsoleWebService : IConsoleWebService
    {
        public void SaveConfig(config config)
        {
            new ConfigOperations().SaveConfig(config);
        }

        public config GetConfig()
        {
            return new ConfigOperations().GetConfig();
        }

        public void SaveInvoice(invoice invoice)
        {
            new InvoiceOperations().SaveInvoice(invoice);
        }

        public void DeleteInvoice(invoice invoice)
        {
            new InvoiceOperations().DeleteInvoice(invoice);
        }

        public IList<invoice> GetInvoiceData()
        {
            return new InvoiceOperations().GetInvoiceData();
        }

        //public invoice GetInvoice(int invoiceId)
        //{
        //    return new InvoiceOperations().GetInvoice(invoiceId);
        //}

        public IList<invoice> FetchListForJpk(DateTime dateFrom, DateTime dateTo)
        {
            return new InvoiceOperations().FetchListForJpk(dateFrom, dateTo);
        }
    }
}
