using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDükkanı.Entity.Entity
{
    public class Director
    {
        public string DirecktorName { get; set; }
        public string DirecktorLastName { get; set; }


        public int MovieId { get; set; }
        public  List <Movie>Movie { get; set; }



    }
}
