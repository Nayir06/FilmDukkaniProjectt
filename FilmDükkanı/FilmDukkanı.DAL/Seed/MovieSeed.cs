using FilmDükkanı.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDukkanı.DAL.Seed
{
    public class MovieSeed
    {
        public static List<Movie> Movies = new List<Movie>()
        {
            new Movie{Id=1,FılmAdı="merhaba"}
        };
    }
}
