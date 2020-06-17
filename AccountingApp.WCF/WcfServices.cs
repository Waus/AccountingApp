using AccountingApp.Logic;
using AccountingApp.Model;
using System;
using System.Collections.Generic;

namespace AccountingApp.WCF
{
    public class WcfServices : IWcfServices
    {
        public config GetConfig(int configId)
        {
            return new ConfigOperations().GetConfig(configId);
        }

        public IList<invoice> GetInvoiceList()
        {
            return new InvoiceOperations().GetInvoiceList();
        }

        public invoice GetInvoice(int invoiceId)
        {
            return new InvoiceOperations().GetInvoice(invoiceId);
        }

        public IList<invoice> FetchListForJpk(DateTime dateFrom, DateTime dateTo)
        {
            return new InvoiceOperations().FetchListForJpk(dateFrom, dateTo);
        }
    }
}
