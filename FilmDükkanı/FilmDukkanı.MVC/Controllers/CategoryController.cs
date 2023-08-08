using FılmDukkanı.BLL.AbstractService;
using Microsoft.AspNetCore.Mvc;

namespace FilmDukkanı.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var categorires=_categoryService.GetAllCategories();
            return View();
        }
    }
}
