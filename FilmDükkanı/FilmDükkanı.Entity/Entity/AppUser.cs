using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FilmDükkanı.Entity.Entity
{
    public class AppUser
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


        //kredi Kartı

        [Required(ErrorMessage = "Kredi Kartı Numarası Boş Geçilemez!")]
        [Display(Name = "Kredi Kartı Numarası")]
        public string CreditCardNumber { get; set; }

        [Required(ErrorMessage = "Kredı Kartı Son Kullanma Tarihi Boş Geçielemz")]
        [Display(Name = "Son Kullanma Tarihi")]
        public string CardExpiryDate { get; set; }
        [Required(ErrorMessage = "Cvc Kodu Boş Geçilemez!")]
        [Display(Name = "Cvc Kodu")]
        public string CvcCode { get; set; }
        [Required(ErrorMessage = "Adress Boş Geçilemez!")]
        [Display(Name = "Adress")]

        public String Adress { get; set; }

        [Required(ErrorMessage = "Telefon Numarası Boş Geçielemz")]
        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }


        public List<Movie> Movies { get; set; }
        public Paket paket { get; set; }
    }
}
