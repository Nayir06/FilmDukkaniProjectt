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
    public class PaketService : IPaketService
    {
        private IRepository<Paket> _paketrepository;


        public PaketService(IRepository<Paket> repository)
        {
            _paketrepository = repository;
        }


        public string CreatePaket(Paket paket)
        {
            try
            {
                _paketrepository.Create(paket);
                return "veri olusturuldu";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeletePaket(Paket paket)
        {
            try
            {
                paket.Status = FilmDükkanı.Entity.Enum.Status.Deleted;
                _paketrepository.Update(paket);
                return "veri silindi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Paket FindPaket(int id)
        {
            return _paketrepository.GetById(id);
        }

        public IEnumerable<Paket> GetAllPaket()
        {
            return _paketrepository.GetAll().ToList();
        }

        

        public string UpdatePaket(Paket paket)
        {
            try
            {
                paket.Status = FilmDükkanı.Entity.Enum.Status.Updated;
                return _paketrepository.Update(paket);
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }

        Category IPaketService.FindPaket(int id)
        {
            throw new NotImplementedException();
        }
    }
}

