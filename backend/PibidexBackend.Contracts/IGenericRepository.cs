using PibidexBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PibidexBackend.Contracts
{
    public interface IGenericRepository<TEntity, TPrimaryKey> where TEntity : EntityBase<TPrimaryKey>
    {
        public Task<bool> Add(TEntity entity);
        public Task<TEntity> Find(TPrimaryKey id, bool asTracking, params Expression<Func<TEntity, object>>[] navigationProperties);
        public Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] navigationProperties);
        public Task<bool> Remove(TPrimaryKey id);
        public Task<bool> Remove(TEntity entity);
        public Task<bool> Update(TEntity entity);
    }
}