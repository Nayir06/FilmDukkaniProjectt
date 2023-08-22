using FılmDukkanı.BLL.Abstract;
using FılmDukkanı.BLL.AbstractService;
using FilmDükkanı.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FılmDukkanı.BLL.Service
{
    public class CategoryService : ICategoryService
    {

        private IRepository<Category> _categoryrepository;


        public CategoryService(IRepository <Category> repository)
        {
            _categoryrepository = repository;
        }


        public string CreateCategory(Category category)
        {
            try
            {
                _categoryrepository.Create(category);
                    return "veri olusturuldu";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteCategory(Category category)
        {
            try
            {
                category.Status = FilmDükkanı.Entity.Enum.Status.Deleted;
                _categoryrepository.Update(category);
                return "veri silindi";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public Category FindCategory(int id)
        {
           return _categoryrepository.GetById(id);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryrepository.GetAll().ToList();
        }

        public string UpdateCategory(Category category)
        {
            try
            {
                category.Status = FilmDükkanı.Entity.Enum.Status.Updated;
                return _categoryrepository.Update(category);
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
    }
}
