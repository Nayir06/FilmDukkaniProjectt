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


        //confırmation
        public async Task<IActionResult> Confirmation(string? id, string? token)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return RedirectToAction("Register");
            }

            var decodedToken = HttpUtility.UrlDecode(token); // Here we decode the token
            var result = await _userManager.ConfirmEmailAsync(user, decodedToken);

            //var confirm = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                return View("Index");
            }
            else
            {
                return RedirectToAction("Register");
            }


        }
    }
}