using Demo_03_MVC_Forms_Validation.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// - - - - - - - - - - - - - - - - - - - - - - - - - 

// New code added. This will allow us to 'inject' the UserRepository into any controller that askes for it.
// This time, for demo purposes, we are using .AddSingleton because this will allow us to see some persistant data in the UserRepository while the app is running.

builder.Services.AddSingleton<UserRepository>();

// - - - - - - - - - - - - - - - - - - - - - - - - -

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
