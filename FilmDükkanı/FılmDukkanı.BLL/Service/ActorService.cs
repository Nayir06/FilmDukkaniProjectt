using FılmDukkanı.BLL.Abstract;
using FılmDukkanı.BLL.AbstractService;
using FilmDükkanı.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FılmDukkanı.BLL.Service
{
    public class ActorService : IActorService
    {
        private IRepository<Actor> _actorrepository;


        public ActorService(IRepository<Actor> repository)
        {
            _actorrepository = repository;
        }


        public string CreateActor(Actor actor)
        {
            try
            {
                _actorrepository.Create(actor);
                return "veri olusturuldu";
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
                actor.Status = FilmDükkanı.Entity.Enum.Status.Deleted;
                _actorrepository.Update(actor);
                return "veri silindi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Actor FindActor(int id)
        {
            return _actorrepository.GetById(id);
        }

        public IEnumerable<Actor> GetAllActor()
        {
            return _actorrepository.GetAll().ToList();
        }

        public string UpdateActor(Actor actor)
        {
            try
            {
                actor.Status = FilmDükkanı.Entity.Enum.Status.Updated;
                return _actorrepository.Update(actor);
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
    }
}
