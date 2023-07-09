using FilmDükkanı.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FilmDukkanı.DAL.Seed
{
    internal class CategorySeed
    {
        public static List<Category> Categories = new List<Category>()
        {
            new Category{Id=1,CategoryName="elma"},
        };
    }
}
