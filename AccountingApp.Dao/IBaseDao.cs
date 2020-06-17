using System.Collections.Generic;

namespace AccountingApp.Dao
{
    public interface IBaseDao<TEntity>
        where TEntity : class, new()
    {
        void Save(TEntity entity);
        void Delete(TEntity entity);
        IList<TEntity> FetchList();
        TEntity Get(int entityId);
    }
}
