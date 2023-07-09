using FılmDukkanı.BLL.Abstract;
using FilmDukkanı.DAL.Context;
using FilmDükkanı.Entity.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FılmDukkanı.BLL.Concrete
{
    internal class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly FılmDukkanıContext _context;
        private readonly DbSet<T> _entities; // buraya gelen ürünü set ediyor

        //cast yapıldı
        public BaseRepository(FılmDukkanıContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }
        public string Create(T entity)
        {
            try
            {

                _entities.Add(entity);
                _context.SaveChanges();

                return "veri kaydedildi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Delete(T entity)
        {
            try
            {
                var deleted = GetById(entity.Id);
                deleted.Status = FilmDükkanı.Entity.Enum.Status.Deleted;

                Update(deleted);
                return "veri silindi!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.Where(x => x.Status == FilmDükkanı.Entity.Enum.Status.Created || x.Status == FilmDükkanı.Entity.Enum.Status.Updated);
        }

        public T GetById(int id)
        {
            var entity = _entities.Find(id);
            return entity;
        }

        public string Update(T entity)
        {
            string result = "";
            try
            {
                switch (entity.Status)
                {

                    case FilmDükkanı.Entity.Enum.Status.Updated:
                        entity.Status = FilmDükkanı.Entity.Enum.Status.Updated;
                        _context.Entry(entity).State = EntityState.Modified;
                        _context.SaveChanges();
                        result = "veri güncellendi";
                        break;
                    case FilmDükkanı.Entity.Enum.Status.Deleted:
                        entity.Status = FilmDükkanı.Entity.Enum.Status.Deleted;
                        _context.SaveChanges();
                        result = "veri güncellendi";
                        break;


                }
            }
            catch (Exception ex)
            {

                result = ex.Message;
            }
            return result;
        }
    }
}
