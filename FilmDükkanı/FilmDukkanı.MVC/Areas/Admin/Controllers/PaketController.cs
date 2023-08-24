using FılmDukkanı.BLL.AbstractService;
using FilmDükkanı.Entity.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FilmDukkanı.MVC.Areas.Admin.Controllers
{
    public class PaketController : Controller
    {
        private readonly IPaketService _PaketService;

        public PaketController(IPaketService paketService)
        {
            _PaketService = paketService;
        }
        public IActionResult Index()
        {

            return View(_PaketService.GetAllPaket());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Paket paket)
        {
            _PaketService.CreatePaket(paket);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(int id)
        {
            var deleted = _PaketService.FindPaket(id);

            
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Update(int id)
        {
            var uptated = _PaketService.GetAllPaket().Where(x => x.Id == id).FirstOrDefault();
            return View(uptated);
        }
        [HttpPost]
        public IActionResult Update(Paket paket)
        {
            _PaketService.UpdatePaket(paket);
            return RedirectToAction("Index", "Home");
        }
    }
}
