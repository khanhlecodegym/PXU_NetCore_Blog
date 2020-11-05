using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.IRepository;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class PostRepository : IPost
    {
        private readonly AppDbContext appDbContext;

        public PostRepository(AppDbContext _appDbContex)
        {
            appDbContext = _appDbContex;
        }

        public void Delete(Post post)
        {
            appDbContext.Remove(post);
        }

        public List<Post> GetAll()
        {
            return appDbContext.Posts.ToList();
        }

        public Post GetById(int id)
        {
            return appDbContext.Posts.FirstOrDefault(p => p.Id == id);
        }

        public void Insert(Post post)
        {
            appDbContext.Add(post);
        }

        public void Update(Post post)
        {
            appDbContext.Update(post);
        }
    }
}
