using Galeri.Core.Repository;
using Galeri.Core.Services;
using Galeri.Core.UnitOfWorks;
using Galeri.Repository.AppDbContexts;
using Galeri.Repository.Repositories;
using Galeri.Repository.UnitOfWorks;
using Galeri.Service.Mappings;
using Galeri.Service.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IGenericUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericServices<>));
builder.Services.AddAutoMapper(typeof(MapProfiles));

builder.Services.AddScoped<IAracRepository, AracRepository>();
builder.Services.AddScoped<IAracService, AracService>();

builder.Services.AddScoped<IKategoriRepository, KategoriRepository>();
builder.Services.AddScoped<IKategoriService, KategoriService>();


builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option => {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
