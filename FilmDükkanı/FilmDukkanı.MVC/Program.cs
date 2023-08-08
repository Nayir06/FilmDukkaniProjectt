using FýlmDukkaný.BLL.Abstract;
using FýlmDukkaný.BLL.AbstractService;
using FýlmDukkaný.BLL.Concrete;
using FýlmDukkaný.BLL.Service;
using FilmDukkaný.DAL.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//servira baðlanma
builder.Services.AddDbContext<FýlmDukkanýContext>();

//servisler
builder.Services.AddTransient(typeof(IRepository<>),typeof(BaseRepository<>));
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

    //default

    endpoints.MapDefaultControllerRoute();

    //admin için
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
