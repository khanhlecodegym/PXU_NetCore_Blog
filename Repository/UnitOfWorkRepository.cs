using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.IRepository;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class UnitOfWorkRepository : IUnitOfWork
    {
        private readonly AppDbContext appDbContext;
        private IPost postRepository;
        private ITag tapRepository;

        public UnitOfWorkRepository(AppDbContext _appDbContext)
        {
            appDbContext = _appDbContext;
        }

        public IPost Post
        {
            get
            {
                return postRepository = postRepository ?? new PostRepository(appDbContext);
            }
        }

        public ITag Tag
        {
            get
            {
                return tapRepository = tapRepository ?? new TagRepository(appDbContext);
            }
        }

        public ICategory Category => throw new NotImplementedException();

        public void Save()
        {
            appDbContext.SaveChanges();
        }
    }
}
