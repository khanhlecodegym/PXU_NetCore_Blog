using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.IRepository
{
    public interface IUnitOfWork
    {
        IPost Post { get; }
        ITag Tag { get; }
        ICategory Category { get; }

        void Save();
    }
}
