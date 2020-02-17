using JPK_generator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPK_generator.Dao
{
    class MainFormDao
    {
        public db0Entities context { get; set; }
        public MainFormDao()
        {
            context = new db0Entities();
        }

        public void Save(invoice invoice)
        {
            context.invoice.Add(invoice);
            //test invoice = entity as test;
            //context.test.Add(invoice);
            context.SaveChanges();
        }

        public IList<invoice> GetInvoices()
        {
            return context.invoice.ToList();
        }

        public invoice GetInvoice(int invoiceId)
        {
            return context.invoice.Where(a => a.invoice_id == invoiceId).FirstOrDefault();
        }
    }
}
