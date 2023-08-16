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
        IEnumerable<Actor> GetAllCategories();


        string CreateActor(Actor Actor);


        string DeleteActor(Actor Actor);
        string UpdateActor(Actor Actor);
        Actor FindActor(int id);

    }
}
