using FılmDukkanı.BLL.AbstractService;
using FilmDükkanı.Entity.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FilmDukkanı.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IDirectorService _directorService;
        private readonly ICategoryService _categoryService;
        private readonly IActorService _actorService;

        public HomeController(IMovieService movieService, IDirectorService directorService, ICategoryService categoryService, IActorService actorService)
        {
            _movieService = movieService;
            _directorService = directorService;
            _categoryService = categoryService;
            _actorService = actorService;
        }
        public IActionResult Index()
        {
            ViewBag.Movie = _movieService.GetAllMovies().Count();//Film sayısı
            ViewBag.Director =_directorService.GetAllDirector().Count();
           


            



            return View(_movieService.GetAllMovies().ToList());
        }


    }
}
