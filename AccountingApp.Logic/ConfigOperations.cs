using AccountingApp.Dao;
using AccountingApp.Model;

namespace AccountingApp.Logic
{
    public class ConfigOperations : BaseCrudOperations<IConfigDao, config>
    {
        public ConfigOperations(IConfigDao configDao)
        {
            Dao = configDao;
        }

        public config GetConfig()
        {
            return Dao.GetConfig();
        }
    }
}