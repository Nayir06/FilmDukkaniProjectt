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
    public class DirectorService : IDirectorService
    {
        private IRepository<Director> _directorrepository;


        public DirectorService(IRepository<Director> repository)
        {
            _directorrepository = repository;
        }


        public string CreateDirector(Director Director)
        {
            try
            {
                _directorrepository.Create(Director);
                return "veri olusturuldu";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteDirector(Director Director)
        {
            try
            {
                Director.Status = FilmDükkanı.Entity.Enum.Status.Deleted;
                _directorrepository.Update(Director);
                return "veri silindi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Director FindDirector(int id)
        {
            return _directorrepository.GetById(id);
        }

        public IEnumerable<Director> GetAllDirector()
        {
            return _directorrepository.GetAll().ToList();
        }

       
        public string UpdateDirector(Director Director)
        {
            try
            {
                Director.Status = FilmDükkanı.Entity.Enum.Status.Updated;
                return _directorrepository.Update(Director);
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
    }
}
