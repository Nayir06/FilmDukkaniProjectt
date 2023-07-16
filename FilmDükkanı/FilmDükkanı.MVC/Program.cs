using F�lmDukkan�.BLL.Abstract;
using F�lmDukkan�.BLL.AbstractService;
using F�lmDukkan�.BLL.Concrete;
using F�lmDukkan�.BLL.Service;
using FilmDukkan�.DAL.Context;
using FilmD�kkan�.Entity.Base;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<F�lmDukkan�Context>();

//servisler

builder.Services.AddIdentity<IdentityUser,IdentityRole>().AddEntityFrameworkStores<F�lmDukkan�Context>();

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
