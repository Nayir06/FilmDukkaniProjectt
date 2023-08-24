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
        private readonly IPaketService _paketService;

        public HomeController(IMovieService movieService, IDirectorService directorService, ICategoryService categoryService, IActorService actorService/*IPaketService paketService*/)
        {
            _movieService = movieService;
            _directorService = directorService;
            _categoryService = categoryService;
            _actorService = actorService;
            //_paketService = paketService;
        }
        public IActionResult Index()
        {
            ViewBag.Movie = _movieService.GetAllMovies().Count();//Film sayısı
            ViewBag.Director =_directorService.GetAllDirector().Count();
           


            



            return View(_movieService.GetAllMovies().ToList());
        }


    }
}
