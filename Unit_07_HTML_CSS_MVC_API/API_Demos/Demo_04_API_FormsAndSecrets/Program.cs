using Demo_04_API_FormsAndSecrets.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

/* New code added below!  - - - - - - - - - - - - - - - - - - - - - - - - - - 
 * 
 * 
 */

builder.Services.AddHttpClient<CityApiService>(c =>                    // Add the HttpClient and Service file you created
{
    string apiKey = builder.Configuration["ApiNinja:ApiKey"];          // Access the API key from the user secrets.
    c.BaseAddress = new Uri("https://api.api-ninjas.com/v1/");         // Set the base URL for the API calls
    c.DefaultRequestHeaders.Add("X-Api-Key", apiKey);                  // Add the API key to the Request Header
});


/* 
 * New code section ends here. - - - - - - - - - - - - - - - - - - - - - - - - 
 */

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
