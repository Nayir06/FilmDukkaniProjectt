using FilmDükkanı.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FılmDukkanı.BLL.Abstract
{
    public interface IRepository<T> where T :BaseEntity
    {
        //list
        IEnumerable<T> GetAll();

        //create
        string Create (T entity);

        //delete

        string Delete (T entity);

        //update

        string Update (T entity);
       
        
        //find

        T GetById(int id);
    }
}
