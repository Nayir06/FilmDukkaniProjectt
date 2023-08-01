using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FilmDükkanı.MVC.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        public IActionResult Profile(int id)
        {
            return View();
        }
    }
}
