using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallop.Generic
{
    public interface IGenericRepo<TEntity, TIdentity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(TIdentity id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TIdentity id);

        // async method
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetAsync(TIdentity id);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task RemoveAsync(TIdentity id);
    }
}
