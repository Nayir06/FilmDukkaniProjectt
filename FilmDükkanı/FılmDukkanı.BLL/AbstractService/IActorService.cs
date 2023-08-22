using FilmDükkanı.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FılmDukkanı.BLL.AbstractService
{
    public interface IActorService
    {
        IEnumerable<Actor> GetAllActor();


        string CreateActor(Actor actor);


        string DeleteActor(Actor actor);
        string UpdateActor(Actor actor);
        Actor FindActor(int id);

    }
}
