﻿using AccountingApp.Dao;
using AccountingApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp.EF
{
    public abstract class BaseDao<TEntity> : IBaseDao<TEntity>
        where TEntity : class, new()
    {
        public AccountingAppEntities context { get; set; }
        public BaseDao()
        {
            context = new AccountingAppEntities();
        }

        //public void SaveNew(TEntity entity)
        //{
        //    DbSet dbSet = context.Set(typeof(TEntity));
        //    dbSet.Add(entity);
        //    context.SaveChanges();
        //}

        public void Save(TEntity entity)
        {
            var keyName = context.GetKeyNames<TEntity>();
            var key = keyName[0];
            var value = (int)entity.GetType().GetProperty(key).GetValue(entity, null);
            context.Entry(entity).State = value == 0 ? EntityState.Added : EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            DbSet dbSet = context.Set(typeof(TEntity));
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        public abstract IList<TEntity> FetchList();

        public abstract TEntity Get(int entityId);
    }
}