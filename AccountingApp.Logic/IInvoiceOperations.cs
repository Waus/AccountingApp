using AccountingApp.Model;
using System;
using System.Collections.Generic;

namespace AccountingApp.Logic
{
    public interface IInvoiceOperations
    {

        void SaveInvoice(invoice invoice);

        void DeleteInvoice(invoice invoice);

        IList<invoice> GetInvoiceData();

        invoice GetInvoice(int invoiceId);

        IList<invoice> FetchListForJpk(DateTime dateFrom, DateTime dateTo);
    }
}