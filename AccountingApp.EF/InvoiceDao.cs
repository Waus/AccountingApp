using AccountingApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp.EF
{
    public class InvoiceDao : BaseDao<invoice>
    {
        public InvoiceDao()
        {
        }

        public override IList<invoice> FetchList()
        {
            return context.invoice.ToList();
        }

        public override invoice Get(int invoiceId)
        {
            return context.invoice.Where(a => a.invoice_id == invoiceId).FirstOrDefault();
        }

        public IList<invoice> FetchListForJpk(DateTime dateFrom, DateTime dateTo)
        {
            return context.invoice.Where(a => a.date_of_sale >= dateFrom && a.date_of_sale <= dateTo).ToList();
        }
    }
}
