using System.ComponentModel.DataAnnotations;

namespace FilmDükkanı.MVC.Models.ViewModels
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "email adresi boş geçilemez!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "kullanıcı adı boş geçilemez!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "şifre boş geçilemez!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "eşifre (tekrar) boş geçilemez!")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }


        public string KartIsım { get; set;   }
        public string KartNumara { get; set; }
        public DateTime SonKullanmaTarıh { get; set; }
        public string CvvKodu { get; set; }


    }
}
