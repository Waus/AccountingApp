using AccountingApp.Model;

namespace AccountingApp.Logic
{
    public interface IConfigOperations
    {
        void SaveConfig(config config);

        config GetConfig();
    }
}