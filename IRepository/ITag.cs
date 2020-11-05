using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.IRepository
{
    public interface ITag
    {
        List<Tag> GetAll();
        Tag GetById(int id);
        void Insert(Tag post);
        void Update(Tag post);
        void Delete(Tag post);
    }
}
