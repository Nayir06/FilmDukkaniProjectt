using FılmDukkanı.BLL.AbstractService;
using FılmDukkanı.BLL.Service;
using Microsoft.AspNetCore.Mvc;

namespace FilmDukkanı.MVC.Areas.Admin.Controllers
{
    public class MovieController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
