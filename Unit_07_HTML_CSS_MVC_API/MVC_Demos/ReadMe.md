# Demo 2: MVC Forms

# Demo 3: MVC Forms with Validation

# Demo 4: MVC with Entity Framework Core (Code first approach)
This demo starts with creating an AppUser model.
Then, an AppUserContext.cs is created to allow EF core to generate a database.
The connection string to the database is in appsettings.json. Make sure to edit the connection string for you specific needs. The demo only includes a connection string for "Parallels" because I (the author) was connecting to a SQL server across my home network from a windows machine to a mac running SQL Server in docker.
See comments in each .cs file of the project for more information.

To create a code first MVC app using EFC and SQL

1. Create the models you want to exist in your database. (In this example it is AppUser.cs)
2. Create a DbContext class to provide instructions for EF to generate your database. Make sure to inherit from DbContext. Name your context after your database, preferably.
```
    public class AppUserContext : DbContext
    {
        public AppUserContext(DbContextOptions<AppUserContext> options) : base(options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }
    }
```
3. Add a connection string. This can be added in a variety of places. In this demo, we add it to appsettings.json.
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "AppUserContextConnection": "@"Server=.\SQLEXPRESS;Database=MvcEfcDemo04;Trusted_Connection=True;",
  }
}
```
4. In your Program.cs, add your database connection
```
...
builder.Services.AddControllersWithViews();


// Let's add our DbContext that creates the connection to our SQL Server
builder.Services.AddDbContext<AppUserContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:AppUserContextConnection"]);
});


var app = builder.Build();
...
```
5. In the package manager console, now we can generate the initial 'migration'. A migration is generated code that define instructions that will generate the database for you.
In other words, the migrations our instructions that will map our domain models to our database models. The migration will create a database, and tables and the columns for the tables based on your code.
The context defined that we want a table to made based on the AppUser model. `public DbSet<AppUser> AppUsers { get; set; }` And, the migration will generate the code on how to actually build out the sql table.

In the package manager console, enter: `add-migration InitMigration` InitMigration is just a name we are giving the file that contains the initial database creation instructions.

No database has been created yet! We only have the instructions at this point.

6. Generate the database.
In the package manager console, enter: `update-database` This command will use the migration file instructions to actually create the database.

7. Check your databases and make sure you see the database and the table(s) that EFC generated!

8. Now you can interact with your database through the DbContext file you've created. In this demo, we added an extra layer of abstraction by using a Repository class that definies how to interact with the database so we don't have to directly access the DbContext file from other locations in our app. See the comments in the project for more info!

# Demo 5: MVC with Entity Framework Core (Database first approach)
See readme in Project folder