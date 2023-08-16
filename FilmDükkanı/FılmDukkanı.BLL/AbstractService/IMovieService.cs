using FilmDükkanı.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FılmDukkanı.BLL.AbstractService
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetAllCategories();


        string CreateMovie(Movie Movie);


        string DeleteMovie(Movie Movie);
        string UpdateMovie(Movie Movie);
        Movie FindMovie(int id);

    }
}
