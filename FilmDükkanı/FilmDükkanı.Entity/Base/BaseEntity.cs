using FilmDükkanı.Entity.Enum;
using FilmDükkanı.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDükkanı.Entity.Base
{
    public class BaseEntity : IEntity<Guid>
    {

        public BaseEntity()
        {
            IsActive = true;
            Status = Status.Created;
            CreateDate = DateTime.Now;
            MasterId = Guid.NewGuid();
        
            
        }
        public int Id { get ; set ; }
        public Guid MasterId { get ; set ; }
        public DateTime CreateDate { get ; set ; }
        public bool IsActive { get ; set ; }
        public Status Status { get ; set ; }
    }
}
