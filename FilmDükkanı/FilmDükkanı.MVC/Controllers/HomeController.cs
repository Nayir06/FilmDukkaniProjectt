using FilmDükkanı.MVC.Models;
using FilmDükkanı.MVC.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;

namespace FilmDükkanı.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser();

                user.UserName = registerVM.Username;
                user.Email = registerVM.Email;

                var result = await _userManager.CreateAsync(user, registerVM.ConfirmPassword);
                if (result.Succeeded)
                {

                    var token = await _userManager.GenerateEmailConfirmationTokenAsync(user); ;
                    var encodedToken = HttpUtility.UrlEncode(token); 


                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View(registerVM);
                }

            }
            else { return View(registerVM); }
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}