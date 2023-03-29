using CsvHelper.Configuration;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VaruosadAPI.Data;
using VaruosadAPI.Models;
using CsvHelper;
using CsvHelper.Configuration.Attributes;
using Microsoft.CodeAnalysis.Elfie.Serialization;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SparePartsContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SparePartsContext") ?? throw new InvalidOperationException("Connection string 'SparePartsContext' not found.")));


// Add services to the container.
builder.Services.AddControllersWithViews();



var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    

    SeedData.Initialize(services);
    
    
}

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

