using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallop.Generic
{
    public abstract class UnitOfWork<TContext> : IUnitOfWork where TContext : DbContext
    {
        protected readonly TContext _context;
        public UnitOfWork(TContext context)
        {
            _context = context;
        }
        public virtual int Save()
        {
            return _context.SaveChanges();
        }

        public virtual Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }

        public virtual void Dispose()
        {
            _context.Dispose();
        }

        public virtual ValueTask DisposeAsync()
        {
            return _context.DisposeAsync();
        }

    }
}
