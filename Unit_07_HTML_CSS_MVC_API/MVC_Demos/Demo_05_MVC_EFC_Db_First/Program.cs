/*
 * ASP.NET Database First Entity Framework Core Demo
 * Link: https://learn.microsoft.com/en-us/ef/core/managing-schemas/scaffolding/?tabs=vs
 * 
 * Our goal is to create a SQL database, and then automatically generate C# classes based on that database, as well as have a connection to that database
 * to interact with it from our application, such as reading, writing, and editing that database.
 * 
 * First, create a SQL database. It can be as simple as you'd like.
 * Install the Nuget Package: Microsoft.EntityFrameworkCore.Design
 * 
 * EXAMPLE CLI scaoffolding command:
 *      dotnet ef dbcontext scaffold "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Chinook" Microsoft.EntityFrameworkCore.SqlServer
 * EXAMPLE Package Manager Console command:
 *      Scaffold-DbContext 'Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Chinook' Microsoft.EntityFrameworkCore.SqlServer
 * 
 */


using Demo_05_MVC_EFC_Db_First.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<DessertDbContext>();

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
