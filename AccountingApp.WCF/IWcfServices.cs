using AccountingApp.Model;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace AccountingApp.WCF
{
    [ServiceContract]
    public interface IWcfServices
    {
        [OperationContract]
        config GetConfig(int configId);

        [OperationContract]
        IList<invoice> GetInvoiceList();

        [OperationContract]
        invoice GetInvoice(int invoiceId);

        [OperationContract]
        IList<invoice> FetchListForJpk(DateTime dateFrom, DateTime dateTo);
    }
}
