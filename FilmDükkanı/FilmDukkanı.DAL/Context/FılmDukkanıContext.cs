using FilmDukkanı.DAL.Seed;
using FilmDükkanı.Entity.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FilmDukkanı.DAL.Context
{
    public class FılmDukkanıContext:IdentityDbContext
    {

        
        //tablo olusturma 

        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {


            //Category
            builder.Entity<Category>().HasData(CategorySeed.Categories);


            //Product
            builder.Entity<Movie>().HasData(MovieSeed.Movies);

            base.OnModelCreating(builder);
        }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            
            
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-TQ757R7\\hasan;database=ProjeFilmmi;uid=sa;pwd=123");
            }
        }
    }
}
