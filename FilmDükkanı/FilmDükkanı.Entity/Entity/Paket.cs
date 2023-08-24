using FilmDükkanı.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDükkanı.Entity.Entity
{
    public class Paket:BaseEntity
    {
        public string UyelıkModelı { get ; set; }
        public string Degisim { get; set; }
        public string AylıkYaklasıkFılmSayısı { get ; set; }
        public Decimal AylıkUcret { get ; set; }


        //tables


        public List<AppUser> Users { get; set; }
    }
}
