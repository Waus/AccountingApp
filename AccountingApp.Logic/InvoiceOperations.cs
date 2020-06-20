using AccountingApp.Dao;
using AccountingApp.EF;
using AccountingApp.Model;
using System;
using System.Collections.Generic;

namespace AccountingApp.Logic
{
    public class InvoiceOperations
    {
        private readonly IInvoiceDao dao;

        public InvoiceOperations()
        {
            dao = new InvoiceDao();
        }

        public void SaveInvoice(invoice invoice)
        {
            dao.Save(invoice);
        }

        public void DeleteInvoice(invoice invoice)
        {
            dao.Delete(invoice);
        }

        public IList<invoice> GetInvoiceData()
        {
            return dao.FetchList();
        }

        public invoice GetInvoice(int invoiceId)
        {
            return dao.Get(invoiceId);
        }

        public IList<invoice> FetchListForJpk(DateTime dateFrom, DateTime dateTo)
        {
            return dao.FetchListForJpk(dateFrom, dateTo);
        }
    }
}
