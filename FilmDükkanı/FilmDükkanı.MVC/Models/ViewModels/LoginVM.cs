using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FilmDükkanı.MVC.Models.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Email boş geçilemez!")]
        [Display(Name = "Eposta")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
    }
}
