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

        public void Delete(Tag tag)
        {
            appDbContext.Remove(tag);
        }

        public List<Tag> GetAll()
        {
            return appDbContext.Tags.ToList();
        }

        public Tag GetById(int id)
        {
            return appDbContext.Tags.FirstOrDefault(p => p.Id == id);
        }

        public void Insert(Tag tag)
        {
            appDbContext.Add(tag);
        }

        public void Update(Tag tag)
        {
            appDbContext.Update(tag);
        }
    }
}
