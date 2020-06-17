using AccountingApp.Model;
using System;
using System.Collections.Generic;

namespace AccountingApp.Dao
{
    public interface IInvoiceDao : IBaseDao<invoice>
    {
        IList<invoice> FetchListForJpk(DateTime dateFrom, DateTime dateTo);
    }
}
