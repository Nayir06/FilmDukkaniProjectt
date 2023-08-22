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
        IEnumerable<Movie> GetAllMovies();


        string CreateMovie(Movie movie);


        string DeleteMovie(Movie movie);
        string UpdateMovie(Movie movie);
        Movie FindMovie(int id);

    }
}
