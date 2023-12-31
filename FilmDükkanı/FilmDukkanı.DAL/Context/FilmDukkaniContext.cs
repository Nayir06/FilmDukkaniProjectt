﻿using FilmDukkanı.DAL.Seed;
using FilmDükkanı.Entity.Base;
using FilmDükkanı.Entity.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FilmDukkanı.DAL.Context
{
    public class FilmDukkaniContext:IdentityDbContext
    {
        public FilmDukkaniContext(DbContextOptions<FilmDukkaniContext> options) : base(options)
        {

        }

        //tables
        public DbSet<Category> Category { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }


        //kayıt işlemi
        public override int SaveChanges()
        {
            var ModifierEntries = ChangeTracker.Entries().Where(x => x.State == EntityState.Modified || x.State == EntityState.Added);
            try
            {
                foreach(var item in ModifierEntries)
                {
                    var entityRepository = item.Entity as BaseEntity;
                    if(item.State == EntityState.Modified)
                    {
                     
                    }
                    else if (item.State == EntityState.Added)
                    {

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return base.SaveChanges();
        }

        //tablo olusturma 

       
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
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-TQ757R7\\hasan;database=FılmDukkanıDb;uid=sa;pwd=123;");
            }
            base.OnConfiguring(optionsBuilder);
        }



    }
}
