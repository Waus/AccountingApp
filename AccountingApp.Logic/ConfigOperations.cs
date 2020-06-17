using AccountingApp.Dao;
using AccountingApp.EF;
using AccountingApp.Model;

namespace AccountingApp.Logic
{
    public class ConfigOperations
    {
        private IConfigDao dao;

        public ConfigOperations()
        {
            dao = new ConfigDao();
        }

        public config GetConfig(int configId)
        {
            return dao.Get(configId);
        }
    }
}