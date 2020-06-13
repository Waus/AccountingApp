using AccountingApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp.Dao
{
    public interface IInvoiceDao : IBaseDao<invoice>
    {
        IList<invoice> FetchListForJpk(DateTime dateFrom, DateTime dateTo);
    }
}
