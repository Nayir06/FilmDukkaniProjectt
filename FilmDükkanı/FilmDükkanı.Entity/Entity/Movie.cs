using FilmDükkanı.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDükkanı.Entity.Entity
{
    public class Movie:BaseEntity
    {
        [Required]
        [MaxLength(255)]
        public  string FılmAdı { get; set; }
        public string OrjınalFılmAdı { get; set; }
       

        public string YapımYılı { get; set; }
        

        public Double FılmSuresı { get; set; }
        

        public string ImagePath { get; set; }

        //mapping ilişkilendirme


        public int DirectorId { get; set; }

        public virtual List <Category> Category { get; set; }
        public  virtual Director Director { get; set; }
        

    }
}
