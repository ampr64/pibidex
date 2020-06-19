using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PibidexBackend.Contracts;
using PibidexBackend.Entities;

namespace PibidexBackend.Data
{
    public class GenericRepository<TEntity, TPrimaryKey> : IGenericRepository<TEntity, TPrimaryKey> where TEntity : EntityBase<TPrimaryKey>
    {
        public Task<bool> Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Find(TPrimaryKey id, bool asTracking, params Expression<Func<TEntity, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}