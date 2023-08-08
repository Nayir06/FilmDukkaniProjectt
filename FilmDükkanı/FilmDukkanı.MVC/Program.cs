using F�lmDukkan�.BLL.Abstract;
using F�lmDukkan�.BLL.AbstractService;
using F�lmDukkan�.BLL.Concrete;
using F�lmDukkan�.BLL.Service;
using FilmDukkan�.DAL.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//servira ba�lanma
builder.Services.AddDbContext<F�lmDukkan�Context>();

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

    //admin i�in
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
