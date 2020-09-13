using AccountingApp.Dao;

namespace AccountingApp.Logic
{
    public class BaseCrudOperations<TDao, TEntity> : IBaseCrudOperations<TEntity>
        where TDao : IBaseDao<TEntity>
        where TEntity : class, new()
    {
        protected TDao Dao;

        public virtual void Save(TEntity entity)
        {
            Dao.Save(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            Dao.Delete(entity);
        }
    }
}