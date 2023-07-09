using FılmDukkanı.BLL.AbstractService;
using FılmDukkanı.BLL.Service;
using Microsoft.AspNetCore.Mvc;

namespace FilmDükkanı.MVC.Controllers
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
            var categories=_categoryService.GetAllCategories();
            return View();
        }
    }
}
