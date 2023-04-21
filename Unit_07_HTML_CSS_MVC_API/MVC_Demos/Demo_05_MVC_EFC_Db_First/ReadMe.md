# MVC and Entity Framework Core, Database first

Steps to creating a SQL database, and connecting it to an MVC web app using EF core. 

1. Create your SQL database. For example, here are SQL commands that create a simple database with one table that contains desserts.
```
CREATE DATABASE DessertDb;

USE DessertDb;

CREATE TABLE Desserts (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50) NOT NULL,
    Type NVARCHAR(50) NOT NULL,
    Price DECIMAL(5, 2) NOT NULL,
    Available BIT NOT NULL
);

INSERT INTO Desserts (Name, Type, Price, Available)
VALUES ('Chocolate Cake', 'Cake', 10.50, 1),
       ('Strawberry Cheesecake', 'Cheesecake', 12.00, 1),
       ('Lemon Tart', 'Tart', 8.25, 1),
       ('Apple Pie', 'Pie', 9.75, 0),
       ('Vanilla Ice Cream', 'Ice Cream', 4.50, 1);
	   ('Chocolate Chip Cookie', 'Cookie', 1.50, 1),
       ('Blueberry Muffin', 'Muffin', 2.75, 1),
       ('Tiramisu', 'Cake', 11.00, 1),
       ('Pecan Pie', 'Pie', 10.00, 0),
       ('Carrot Cake', 'Cake', 10.50, 1),
       ('Raspberry Sorbet', 'Sorbet', 4.00, 1),
       ('Creme Brulee', 'Custard', 6.50, 1),
       ('Brownie', 'Bar', 2.00, 1),
       ('Peanut Butter Cookie', 'Cookie', 1.75, 1),
       ('Red Velvet Cake', 'Cake', 11.50, 0),
       ('Key Lime Pie', 'Pie', 9.50, 1),
       ('Banana Bread', 'Bread', 7.00, 1),
       ('Black Forest Cake', 'Cake', 12.00, 1),
       ('Mango Ice Cream', 'Ice Cream', 4.75, 1),
       ('Chocolate Eclair', 'Pastry', 3.50, 1),
       ('Oatmeal Raisin Cookie', 'Cookie', 1.50, 1),
       ('Pumpkin Pie', 'Pie', 9.00, 0),
       ('Cupcake', 'Cupcake', 2.50, 1),
       ('Bread Pudding', 'Pudding', 6.00, 1),
       ('Gelato', 'Ice Cream', 4.25, 1);

```

2. Create your ASP.NET MVC project.

3. Add necessary NuGet Packages:
```
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Design
```
Right click on your project in the solution explorer, and select "Manage NuGet Packages..." 

4. In the PMC (Package Manager Console), you can now run commands to generate code that will help you connect to your SQL database.
```
Scaffold-DbContext "Server=.\SQLExpress;Database=DessertDb;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```
You may need to change the name of the Server, and the Database.
This command will create a DbContext class for you, and create model classes for your database tables.

5. Now you can add your new context class (DessertDbContext) to Program.cs.
```
...

// Add services to the container.
builder.Services.AddControllersWithViews();

// NEW CODE: add DessertDBContext as a service so it can be injected into controllers
builder.Services.AddScoped<DessertDbContext>();

var app = builder.Build();
...
```

6. Inject the context class into your controller's constructor.
In the example code below, we are directly passing the DbSet of Desserts to the Index view.
(Another option is to build a repository class that defines methods that provide access to the dbContext. See Demo 04 for that example. 
For the sake of simplicity, we are just accessing the dbContext directly instead.)
```
    public class HomeController : Controller
    {
        private readonly DessertDbContext _db;

        public HomeController(DessertDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Desserts.ToList()); 
        }
    }
```