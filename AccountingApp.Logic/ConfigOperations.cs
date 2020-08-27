using AccountingApp.Dao;
using AccountingApp.Dao.EF;
using AccountingApp.Model;

namespace AccountingApp.Logic
{
    public class ConfigOperations
    {
        private readonly IConfigDao Dao;

        public ConfigOperations(IConfigDao configDao)
        {
            Dao = configDao;
        }

        public void SaveConfig(config config)
        {
            Dao.Save(config);
        }

        public config GetConfig()
        {
            return Dao.GetConfig();
        }
    }
}