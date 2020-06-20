using AccountingApp.Model;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace AccountingApp.WCF
{
    [ServiceContract]
    public interface IConsoleWebService
    {
        [OperationContract]
        void SaveConfig(config config);

        [OperationContract]
        config GetConfig();

        [OperationContract]
        void SaveInvoice(invoice invoice);

        [OperationContract]
        void DeleteInvoice(invoice invoice);

        [OperationContract]
        IList<invoice> GetInvoiceData();

        //[OperationContract]
        //invoice GetInvoice(int invoiceId);

        [OperationContract]
        IList<invoice> FetchListForJpk(DateTime dateFrom, DateTime dateTo);
    }
}
