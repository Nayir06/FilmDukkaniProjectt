using FilmDükkanı.Entity.Entity;
using FılmDukkanı.BLL.AbstractService;
using FılmDukkanı.BLL.Service;
using Microsoft.AspNetCore.Mvc;

namespace FilmDukkanı.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MovieController : Controller
    {
        private readonly IMovieService _MovieService;

        public MovieController(IMovieService movieService)
        {
            _MovieService = movieService;
        }
        public IActionResult Index()
        {

            return View(_MovieService.GetAllMovies());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            _MovieService.CreateMovie(movie);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(int id)
        {
            var deleted = _MovieService.FindMovie(id);

            _MovieService.DeleteMovie(deleted);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Update(int id)
        {
            var uptated = _MovieService.GetAllMovies().Where(x => x.Id == id).FirstOrDefault();
            return View(uptated);
        }
        [HttpPost]
        public IActionResult Update(Movie movie)
        {
            _MovieService.UpdateMovie(movie);
            return RedirectToAction("Index", "Home");
        }
    }
}
