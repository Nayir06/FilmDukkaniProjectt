using FılmDukkanı.BLL.AbstractService;
using FilmDükkanı.Entity.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FilmDukkanı.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DirectorController : Controller
    {
        private readonly IDirectorService _DirectorService;

        public DirectorController(IDirectorService directorService)
        {
            _DirectorService = directorService;
        }
        public IActionResult Index()
        {

            return View(_DirectorService.GetAllDirector());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Director director)
        {
            _DirectorService.CreateDirector(director);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(int id)
        {
            var deleted = _DirectorService.FindDirector(id);

            _DirectorService.DeleteDirector(deleted);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Update(int id)
        {
            var uptated = _DirectorService.GetAllDirector().Where(x => x.Id == id).FirstOrDefault();
            return View(uptated);
        }
        [HttpPost]
        public IActionResult Update(Director director)
        {
            _DirectorService.UpdateDirector(director);
            return RedirectToAction("Index", "Home");
        }
    }
}
