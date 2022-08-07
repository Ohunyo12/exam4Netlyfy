using Microsoft.EntityFrameworkCore;
using smartwallet1.web.Data;
using smartwallet1.web.Data.Entities;
using smartwallet1.web.Data.Repository;
using smartwallet1.web.Data.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(c=> 
                 c.UseSqlServer("Server=localhost\\KASAPRENKO; Database=smartwallet1DB; Trusted_Connection=True;"));

builder.Services.AddScoped<IRepository<Customer, Guid>, CustomerRepository>();

builder.Services.AddScoped<IRepository<Country, Guid>, CountryRepository>();

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

var serviceProvider=app.Services.GetRequiredService<IServiceProvider>();
using (var scope = serviceProvider.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    await SeedHandler.Seed(context);
}

app.Run();

