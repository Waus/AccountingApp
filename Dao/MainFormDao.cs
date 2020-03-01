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

        public void SaveNew(invoice newInvoice)
        {
            context.invoice.Add(newInvoice);
            context.SaveChanges();
        }

        public void Save(invoice newInvoice)
        {
            var editedInvoice = context.invoice.Where(a => a.invoice_id == newInvoice.invoice_id).First();
            newInvoice.invoice_id = editedInvoice.invoice_id;
            context.Entry(editedInvoice).CurrentValues.SetValues(newInvoice);
            context.SaveChanges();
        }

        public void Delete(invoice entity)
        {
            context.invoice.Remove(entity);
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
