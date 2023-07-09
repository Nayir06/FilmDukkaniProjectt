using FilmDükkanı.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FılmDukkanı.BLL.AbstractService
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();


        string CreateCategory (Category category);


        string DeleteCategory (Category category);
        string UpdateCategory (Category category);
        Category FindCategory(int id);


    }
}
