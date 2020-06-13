using AccountingApp.Dao;
using AccountingApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp.EF
{
    public class ConfigDao : BaseDao<config>, IConfigDao
    {
        public ConfigDao()
        {
        }

        public override IList<config> FetchList()
        {
            //throw NotImplementedException;
            return null;
        }

        public override config Get(int configId)
        {
            return context.config.FirstOrDefault();
        }
    }
}
