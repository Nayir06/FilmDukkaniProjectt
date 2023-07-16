using FýlmDukkaný.BLL.Abstract;
using FýlmDukkaný.BLL.AbstractService;
using FýlmDukkaný.BLL.Concrete;
using FýlmDukkaný.BLL.Service;
using FilmDukkaný.DAL.Context;
using FilmDükkaný.Entity.Base;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<FýlmDukkanýContext>();

//servisler

builder.Services.AddIdentity<IdentityUser,IdentityRole>().AddEntityFrameworkStores<FýlmDukkanýContext>();

builder.Services.AddTransient(typeof(IRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<ICategoryService, CategoryService>();

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

app.UseAuthorization();




app.UseEndpoints(endpoints =>
{

    endpoints.MapDefaultControllerRoute();//default buda


    endpoints.MapControllerRoute(   //admin paneli
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
