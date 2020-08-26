using AccountingApp.Dao;
using AccountingApp.EF;
using AccountingApp.Model;

namespace AccountingApp.Logic
{
    public class ConfigOperations : IConfigOperations
    {
        private readonly IConfigDao dao;

        public ConfigOperations()
        {
            dao = new ConfigDao();
        }

        public void SaveConfig(config config)
        {
            dao.Save(config);
        }

        public config GetConfig()
        {
            return dao.GetConfig();
        }
    }
}