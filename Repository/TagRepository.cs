using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.IRepository;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class TagRepository : ITag
    {
        private readonly AppDbContext appDbContext;

        public TagRepository(AppDbContext _appDbContext)
        {
            appDbContext = _appDbContext;
        }

        public void Delete(Tag post)
        {
            throw new NotImplementedException();
        }

        public List<Tag> GetAll()
        {
            throw new NotImplementedException();
        }

        public Tag GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Tag post)
        {
            throw new NotImplementedException();
        }

        public void Update(Tag post)
        {
            throw new NotImplementedException();
        }
    }
}
