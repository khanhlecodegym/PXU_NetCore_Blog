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
        private readonly AppDbContext appDbContex;

        public PostRepository(AppDbContext _appDbContex)
        {
            appDbContex = _appDbContex;
        }

        public void Delete(Post post)
        {
            appDbContex.Remove(post);
        }

        public List<Post> GetAll()
        {
            return appDbContex.Posts.ToList();
        }

        public Post GetById(int id)
        {
            return appDbContex.Posts.FirstOrDefault(p => p.Id == id);
        }

        public void Insert(Post post)
        {
            appDbContex.Add(post);
        }

        public void Update(Post post)
        {
            appDbContex.Update(post);
        }
    }
}
