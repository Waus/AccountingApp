using AccountingApp.Model;

namespace AccountingApp.Dao
{
    public interface IConfigDao : IBaseDao<config>
    {
        config GetConfig();
    }
}
