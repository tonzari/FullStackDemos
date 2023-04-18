

// Api we are using: https://api.api-ninjas.com/v1/animals?name=

using Demo_03_API_With_API_Key.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add the HttpClient here to use dependency injection
builder.Services.AddHttpClient<AnimalApiService>(c =>
{
    string apiKey = builder.Configuration.GetValue<string>("AnimalApi:ApiKey");
    c.BaseAddress = new Uri("https://api.api-ninjas.com/v1/");
    c.DefaultRequestHeaders.Add("X-Api-Key", apiKey);
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
