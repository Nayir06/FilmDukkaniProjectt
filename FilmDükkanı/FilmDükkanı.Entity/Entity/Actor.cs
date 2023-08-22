using FilmDükkanı.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDükkanı.Entity.Entity
{
    public class Actor:BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }    

        public List<Movie>? Movies { get; set; }
        
    }
}
