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

        public config GetConfigData()
        {
            return context.config.FirstOrDefault();
        }

        public void SaveConfig(config newConfig)
        {
            try
            {
                var editedConfig = context.config.Where(a => a.config_id == newConfig.config_id).First();
                newConfig.config_id = editedConfig.config_id;
                context.Entry(editedConfig).CurrentValues.SetValues(newConfig);
            }
            catch
            {
                context.config.Add(newConfig);
            }

            context.SaveChanges();
        }
        
        public IList<invoice> GetInvoicesListForJpk(DateTime dateFrom, DateTime dateTo)
        {
            return context.invoice.Where(a => a.date_of_sale >= dateFrom && a.date_of_sale <= dateTo).ToList();
        }
    }
}
