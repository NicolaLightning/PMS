using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using Abp.Data;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace PMS.EntityFrameworkCore
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="PMSRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class PMSRepositoryBase<TEntity> : PMSRepositoryBase<TEntity, Guid> where TEntity : class, IEntity<Guid>
    {
        /// <summary>
        /// 
        /// </summary>
        private static string connectstr = string.Empty;

        protected PMSRepositoryBase()
        {
            connectstr = PMSDbContextConfigurer.CurrentConnectionString;
        }

        // Do not add any method here, add to the class above (since this inherits it)!!!
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class PMSRepositoryBase<TEntity, TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
    {
        private PMSDbContext context = null;

        protected virtual PMSDbContext Context
        {
            get
            {
                return this.context;
            }
        }

        protected virtual DbSet<TEntity> Table => this.Context.Set<TEntity>();

        protected PMSRepositoryBase()
        {
            this.context = new PMSDbContextFactory().CreateDbContext(null);
        }

        protected virtual bool Insert(TEntity entity)
        {
            Table.Add(entity);
            return this.Save();
        }

        protected virtual bool Update(TEntity entity)
        {
            AttachIfNot(entity);
            Context.Entry(entity).State = EntityState.Modified;
            return this.Save();
        }

        protected virtual bool Delete(TEntity entity)
        {
            AttachIfNot(entity);
            Table.Remove(entity);
            return this.Save();
        }

        protected virtual TEntity Get(TPrimaryKey id)
        {
            var entity = Table.FirstOrDefault(m => m.Id.Equals(id));
            return entity;
        }

        protected virtual TEntity Get(Expression<Func<TEntity,bool>> predicate)
        {
            var entity = Table.FirstOrDefault(predicate);
            return entity;
        }


        protected virtual IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate = null)
        {
            var entity = predicate == null ? this.Table : Table.Where(predicate);
            return entity;
        }

        protected virtual TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            var entity = Table.FirstOrDefault(predicate);
            return entity;
        }

        protected virtual void AttachIfNot(TEntity entity)
        {
            if (!Table.Local.Contains(entity))
            {
                Table.Attach(entity);
            }
        }
        protected virtual bool Save()
        {
            return 0 < this.context.SaveChanges();
        }
    }




}
