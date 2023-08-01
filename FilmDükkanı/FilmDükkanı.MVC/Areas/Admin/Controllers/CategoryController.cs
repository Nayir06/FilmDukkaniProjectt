using FılmDukkanı.BLL.AbstractService;
using FilmDükkanı.Entity.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FilmDükkanı.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
  
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {

            return View(_categoryService.GetAllCategories());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            _categoryService.CreateCategory(category);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(int id)
        {
            var deleted = _categoryService.FindCategory(id);

            _categoryService.DeleteCategory(deleted);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Update(int id)
        {
            var uptated = _categoryService.GetAllCategories().Where(x => x.Id == id).FirstOrDefault();
            return View(uptated);
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {
            _categoryService.UpdateCategory(category);
            return RedirectToAction("Index", "Home");
        }
    }
}
 