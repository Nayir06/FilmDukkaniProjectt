using Microsoft.AspNetCore.Mvc;

namespace FilmDukkanı.MVC.Areas.Admin.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
