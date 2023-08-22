using FilmDükkanı.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FılmDukkanı.BLL.AbstractService
{
    public interface IDirectorService
    {
        IEnumerable<Director> GetAllDirector();


        string CreateDirector(Director director);


        string DeleteDirector(Director director);
        string UpdateDirector(Director director);
        Director FindDirector(int id);

    }
}
