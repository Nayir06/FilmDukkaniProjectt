using Microsoft.AspNetCore.Mvc;

namespace FilmDukkanı.MVC.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
