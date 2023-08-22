using FılmDukkanı.BLL.AbstractService;
using FilmDükkanı.Entity.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FilmDukkanı.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActorController : Controller
    {
        private readonly IActorService _ActorService;

        public ActorController(IActorService actorService)
        {
           _ActorService = actorService;
        }
        public IActionResult Index()
        {

            return View(_ActorService.GetAllActor());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Actor actor)
        {
            _ActorService.CreateActor(actor);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(int id)
        {
            var deleted = _ActorService.FindActor(id);

            _ActorService.DeleteActor(deleted);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Update(int id)
        {
            var uptated = _ActorService.GetAllActor().Where(x => x.Id == id).FirstOrDefault();
            return View(uptated);
        }
        [HttpPost]
        public IActionResult Update(Actor actor)
        {
            _ActorService.UpdateActor(actor);
            return RedirectToAction("Index", "Home");
        }
    }
}
