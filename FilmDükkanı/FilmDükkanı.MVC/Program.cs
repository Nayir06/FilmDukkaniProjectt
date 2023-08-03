using FýlmDukkaný.BLL.Abstract;
using FýlmDukkaný.BLL.AbstractService;
using FýlmDukkaný.BLL.Concrete;
using FýlmDukkaný.BLL.Service;
using FilmDukkaný.DAL.Context;
using FilmDükkaný.Entity.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;
using FýlmDukkaný.IOC.Container;





var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


builder.Services.AddDbContext<FýlmDukkanýContext>(options => options.UseSqlServer(connectionString));

//Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<FýlmDukkanýContext>().AddDefaultTokenProviders();


//servisler

builder.Services.AddIdentity<IdentityUser,IdentityRole>().AddEntityFrameworkStores<FýlmDukkanýContext>();

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

//Services



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

app.UseSession();


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
