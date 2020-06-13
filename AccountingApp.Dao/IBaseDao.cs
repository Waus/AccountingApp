using AccountingApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
