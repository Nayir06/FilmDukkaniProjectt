using FılmDukkanı.BLL.AbstractService;
using FilmDükkanı.Entity.Entity;
using FilmDukkanı.MVC.Models;
using FilmDukkanı.MVC.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;


namespace FilmDukkanı.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMovieService _movieService;
        private readonly IActorService _actorService;
        private readonly IDirectorService _directorService;
        private readonly ICategoryService _categoryService;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        

        public HomeController(ILogger<HomeController> logger, IMovieService movieService,IActorService actorService,IDirectorService directorService,ICategoryService categoryService, UserManager<IdentityUser>userManager,SignInManager<IdentityUser>signInManager) //UserManager<AppUser>userManager)
        {
            _logger = logger;
            _movieService = movieService;
            _actorService = actorService;
            _directorService = directorService;
            _categoryService = categoryService;
            _signInManager = signInManager;
            _userManager = userManager;
            
        }

        public IActionResult Index()
        {   
            MovieAndCategoryVM movieAndCategoryVM = new MovieAndCategoryVM();
            movieAndCategoryVM.Categories=_categoryService.GetAllCategories().ToList();
            movieAndCategoryVM.Movies=_movieService.GetAllMovies().ToList();
            //movieAndCategoryVM.Directors=_directorService.GetAllDirector().ToList();
            //movieAndCategoryVM.Actors=_actorService.GetAllActor().ToList();
            return View();
        }

        public IActionResult Register() 
        {
            return View();       
        }

       [HttpPost]
        public async Task<IActionResult> Register(RegisterVm registerVm)
       {
          if (ModelState.IsValid)
          {
              IdentityUser user=new IdentityUser(); 
                user.UserName = registerVm.Username;
                user.Email = registerVm.Email;
                user.PhoneNumber = registerVm.PhoneNumber;


                

                var result = await _userManager.CreateAsync(user, registerVm.ConfirmPassword);
                if (result.Succeeded)
              {
                  return RedirectToAction("Paket", "Home");
      
              }
              else
              {
                  return View(registerVm);
              }
          }
          else { return View(registerVm); }
      }
       

        public IActionResult Login()
        {
            ViewBag.Categories = _categoryService.GetAllCategories().ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(loginVM.Email);

                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(loginVM);
                    }
                }
                else
                {
                    return View(loginVM);
                }

            }
            return View(loginVM);


        }
            public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Paket()
        {

            return View(); }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}