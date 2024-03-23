
using BlogAPP.Data.Abstract;
using BlogAPP.Data.Concrete;
using BlogAPP.Data.Concrete.EfCore;
using BlogAPP.Entity.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BlogContext>(options =>
{
   var config = builder.Configuration;
   var connectionString = config.GetConnectionString("sql_connection");
   options.UseSqlite(connectionString);
});

builder.Services.AddScoped<IPostRepository, EfPostRepository>();
builder.Services.AddScoped<ITagRepository, EfTagRepository>();
var app = builder.Build();

app.UseStaticFiles();
SeedData.TestVerileriniDoldur(app);

app.MapDefaultControllerRoute();

app.Run();

