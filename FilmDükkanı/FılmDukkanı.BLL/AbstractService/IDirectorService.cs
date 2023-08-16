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
        IEnumerable<Director> GetAllCategories();


        string CreateDirector(Director Director);


        string DeleteDirector(Director Director);
        string UpdateDirector(Director Director);
        Director FindDirector(int id);

    }
}
