using FılmDukkanı.BLL.Abstract;
using FilmDükkanı.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FılmDukkanı.BLL.Service
{
    public class ActorService
    {
        private readonly IRepository<Actor> _actorRepository;

        public ActorService(IRepository<Actor> actorRepository)
        {
            _actorRepository = actorRepository;
        }

        public string CreateActor(Actor actor)
        {
            try
            {
                _actorRepository.Create(actor);

                return "Veri Eklendi!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteActor(Actor actor)
        {
            try
            {


                return _actorRepository.Delete(actor);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Actor FindActor(int id)
        {
            return _actorRepository.GetById(id);
        }

        public IEnumerable<Actor> GetAllActors()
        {
            return _actorRepository.GetAll().ToList();
        }

        public string UpdateActor(Actor actor)
        {
            try
            {


                return _actorRepository.Update(actor);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
