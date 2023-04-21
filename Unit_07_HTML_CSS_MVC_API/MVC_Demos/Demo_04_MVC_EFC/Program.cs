using Demo_04_MVC_EFC.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IAppUserRepository, AppUserRepository>(); // <----- Add the repository as a service here. AddScoped
//builder.Services.AddScoped<IAppUserRepository, MockAppUserRepository>(); // <----- You can swap between the Mock repo and normal repo here! 

builder.Services.AddControllersWithViews();


// Let's add our DbContext that creates the connection to our SQL Server
builder.Services.AddDbContext<AppUserContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:FromParallels"]); // <----- Make sure you are using the correct connection string. See your appsettings.json
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

