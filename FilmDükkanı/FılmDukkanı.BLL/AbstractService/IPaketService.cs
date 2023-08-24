using FilmDükkanı.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FılmDukkanı.BLL.AbstractService
{
    public interface IPaketService
    {
        IEnumerable<Paket> GetAllPaket();


        string CreatePaket(Paket paket);


        string DeletePaket(Paket paket);
        string UpdatePaket(Paket paket);
        Category FindPaket(int id);
    }
}
