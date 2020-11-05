using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.IRepository
{
    public interface IPost
    {
        List<Post> GetAll();
        Post GetById(int id);
        void Insert(Post post);
        void Update(Post post);
        void Delete(Post post);
    }
}
