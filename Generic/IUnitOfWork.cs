using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallop.Generic
{
    public interface IUnitOfWork : IDisposable, IAsyncDisposable
    {
        int Save();
        Task<int> SaveAsync();
    }
}
