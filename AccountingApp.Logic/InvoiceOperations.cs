using AccountingApp.Dao;
using AccountingApp.Dao.EF;
using AccountingApp.Model;
using System;
using System.Collections.Generic;

namespace AccountingApp.Logic
{
    public class InvoiceOperations
    {
        private readonly IInvoiceDao Dao;

        public InvoiceOperations(IInvoiceDao invoiceDao)
        {
            Dao = invoiceDao;
        }

        public void SaveInvoice(invoice invoice)
        {
            Dao.Save(invoice);
        }

        public void DeleteInvoice(invoice invoice)
        {
            Dao.Delete(invoice);
        }

        public IList<invoice> GetInvoiceData()
        {
            return Dao.FetchList();
        }

        public invoice GetInvoice(int invoiceId)
        {
            return Dao.Get(invoiceId);
        }

        public IList<invoice> FetchListForJpk(DateTime dateFrom, DateTime dateTo)
        {
            return Dao.FetchListForJpk(dateFrom, dateTo);
        }
    }
}
