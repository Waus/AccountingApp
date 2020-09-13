using AccountingApp.Dao;
using AccountingApp.Model;
using System;
using System.Collections.Generic;

namespace AccountingApp.Logic
{
    public class InvoiceOperations : BaseCrudOperations<IInvoiceDao, invoice>
    {
        public InvoiceOperations(IInvoiceDao invoiceDao)
        {
            Dao = invoiceDao;
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
