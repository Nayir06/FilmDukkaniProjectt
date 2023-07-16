namespace FilmDükkanı.MVC.Models.ViewModels
{
    public class KrediKartı
    {

        public KrediKartı(string _KartNumarasi, string _Isim, DateTime _SonKullanmaTarihi, string _GuvenlikKodu)
        {
            KartNumarasi = _KartNumarasi;
            Isim = _Isim;
            SonKullanmaTarihi = _SonKullanmaTarihi;
            GuvenlikKodu = _GuvenlikKodu;
        }
        public string KartNumarasi { get; set; }

        public string Isim { get; set; }


        public DateTime SonKullanmaTarihi { get; set; }

        public string GuvenlikKodu { get; set; }


    } 
}    
