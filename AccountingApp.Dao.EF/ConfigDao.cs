using AccountingApp.Dao;
using AccountingApp.Model;
using System.Collections.Generic;
using System.Linq;

namespace AccountingApp.Dao.EF
{
    public class ConfigDao : BaseDao<config>, IConfigDao
    {
        public override IList<config> FetchList()
        {
            return context.config.ToList();
        }

        public override config Get(int configId)
        {
            return context.config.Where(a => a.config_id == configId).FirstOrDefault();
        }

        public config GetConfig()
        {
            return context.config.FirstOrDefault();
        }
    }
}
