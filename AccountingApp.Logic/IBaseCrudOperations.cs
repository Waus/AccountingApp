using AccountingApp.Model;

namespace AccountingApp.Logic
{
    public interface IBaseCrudOperations<TEntity>
    {
        void Save(TEntity entity);

        void Delete(TEntity entity);
    }
}