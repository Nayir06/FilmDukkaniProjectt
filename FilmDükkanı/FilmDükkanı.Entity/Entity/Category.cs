using FilmDükkanı.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDükkanı.Entity.Entity
{
    public class Category:BaseEntity
    {
        [Required]
        [MaxLength(255)]

        
        public string CategoryName { get; set; }

        //mapping ilişkilendirme




        public List<Movie> movies { get; set; }

    }
}
