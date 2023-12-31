using FılmDukkanı.BLL.Abstract;
using FılmDukkanı.BLL.AbstractService;
using FılmDukkanı.BLL.Concrete;
using FılmDukkanı.BLL.Service;
using FilmDukkanı.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//servira bağlanma
builder.Services.AddDbContext<FilmDukkaniContext>(options=>options.UseSqlServer(connectionString));

builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<FilmDukkaniContext>().AddDefaultTokenProviders();


//Cookie
builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath = new PathString("/Home/Login");
    x.AccessDeniedPath = new PathString("/Home/Login");
    x.Cookie = new CookieBuilder
    {
        Name = "loginCookie"
    };
    x.SlidingExpiration = true;
    x.ExpireTimeSpan = TimeSpan.FromMinutes(5);
});


//servisler
builder.Services.AddTransient(typeof(IRepository<>),typeof(BaseRepository<>));
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IDirectorService, DirectorService>();
builder.Services.AddScoped<IActorService, ActorService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();



app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{

    //Admin

    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );





    //Default
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
        );
});

app.Run();
