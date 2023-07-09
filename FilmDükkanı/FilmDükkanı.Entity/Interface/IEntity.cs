using FilmDükkanı.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDükkanı.Entity.Interface
{
    public interface IEntity<T>
    {
        public int Id { get; set; }
        public T MasterId { get; set; }



        //olusturulma
        public DateTime CreateDate { get; set; }
        



        public bool IsActive { get; set; }
        public Status Status { get; set; }


    }
}
