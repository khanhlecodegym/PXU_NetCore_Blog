using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.IRepository
{
    public interface ICategory
    {
        List<Category> GetAll();
        Category GetById(int id);
        void Insert(Category post);
        void Update(Category post);
        void Delete(Category post);
    }
}
