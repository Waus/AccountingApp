using AccountingApp.Dao;
using AccountingApp.EF;
using AccountingApp.Model;
using System;
using System.Collections.Generic;

namespace AccountingApp.Logic
{
    public class InvoiceOperations
    {
        IInvoiceDao dao;

        public InvoiceOperations()
        {
            dao = new InvoiceDao();
        }

        public IList<invoice> GetInvoiceList()
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
