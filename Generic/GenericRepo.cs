using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallop.Generic
{
    public abstract class GenericRepo<TEntity, TIdentity, TContext> : IGenericRepo<TEntity, TIdentity> where TEntity : class
                                                                                            where TContext : DbContext
    {
        protected readonly TContext _context;
        protected readonly DbSet<TEntity> _dbSet;
        public GenericRepo(TContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual Task AddAsync(TEntity entity)
        {
            return Task.Run(() => Add(entity));
        }

        public virtual TEntity Get(TIdentity id)
        {
            return _dbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            if (_dbSet is null)
                return null;
            return _dbSet.ToList();
        }

        public virtual Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return Task.Run(() => GetAll());
        }

        public virtual Task<TEntity> GetAsync(TIdentity id)
        {
            return Task.Run(() => Get(id));
        }

        public virtual void Remove(TIdentity id)
        {
            var entity = _dbSet.Find(id);
            if (entity is null)
                return;
            _dbSet.Remove(entity);
        }

        public virtual Task RemoveAsync(TIdentity id)
        {
            return Task.Run(() => Remove(id));
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public virtual Task UpdateAsync(TEntity entity)
        {
            return Task.Run(() => _dbSet.Update(entity));
        }
    }
}
