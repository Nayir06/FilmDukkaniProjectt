using FilmDükkanı.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDükkanı.Entity.Entity
{
    public class Director:BaseEntity
    {
        [Required]
        public string? DirectorName { get; set; }
        public string? DirectorLastName { get;}


        //mapping 

        
    }
}
