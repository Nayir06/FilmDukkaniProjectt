using FılmDukkanı.BLL.AbstractService;
using FilmDükkanı.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FılmDukkanı.BLL.Abstract;

namespace FılmDukkanı.BLL.Service
{
    public class MovieService : IMovieService
    {
        private IRepository<Movie> _movierepository;


        public MovieService(IRepository<Movie> repository)
        {
            _movierepository = repository;
        }


        public string CreateMovie(Movie Movie)
        {
            try
            {
                _movierepository.Create(Movie);
                return "veri olusturuldu";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteMovie(Movie Movie)
        {
            try
            {
                Movie.Status = FilmDükkanı.Entity.Enum.Status.Deleted;
                _movierepository.Update(Movie);
                return "veri silindi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Movie FindMovie(int id)
        {
            return _movierepository.GetById(id);
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _movierepository.GetAll().ToList();
        }

        public string UpdateMovie(Movie Movie)
        {
            try
            {
                Movie.Status = FilmDükkanı.Entity.Enum.Status.Updated;
                return _movierepository.Update(Movie);
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
    }
}
