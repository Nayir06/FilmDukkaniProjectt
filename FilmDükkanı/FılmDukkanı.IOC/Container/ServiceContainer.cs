using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using FılmDukkanı.BLL.Abstract;
using FılmDukkanı.BLL.AbstractService;
using FılmDukkanı.BLL.Concrete;
using FılmDukkanı.BLL.Service;


namespace FılmDukkanı.IOC.Container
{
    public static class ServiceContainer
    {
        public static void ServiceConfigure(IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<IDirectorService, DirectorService>();

        
         
        }

    }
}
