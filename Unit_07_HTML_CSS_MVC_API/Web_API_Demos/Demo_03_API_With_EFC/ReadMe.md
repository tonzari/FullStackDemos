# ASP.NET Web API with Entity Framework Core using SQL Server (DB FIRST)

This demo is not complete.

There is a .txt file with SQL commands to create a Cafe database. 

No dummy data exists for this particular demo yet.

Steps taken to create this demo: 

1. Create the SQL database.
2. Add NuGet packages + Scaffold the db context and models using EFC.
3. Generate controllers using the Menu and MenuItem classes.
4. Create a custom controller CafeController to create endpoints to add a menu item to a menu.
5. Add dbcontext as a (scoped) service to the program.cs file.

Menus and MenuItems have a many-to-many relationship. There is a map table in the SQL db called: Menu_MenuItem.

The CafeController has an endpoint to map menu IDs to menu item IDs.
A new class was created to facilitate mapping the IDs: AddItemToMenuDto.cs (Dto meaning Data Transfer Object).
```
public class AddItemToMenuDto
{
    public int MenuId { get; set; }
    public int MenuItemId { get; set; }
}
```
A front-end page could make it easy to select a menu item like 'espresso' and add it to a menu like 'lunch menu', and then that page might call the AddItemToMenu endpoint passing the two IDs involved.
This Cafe menu example is a bit contrived, but the underlying functionality is the main point of the demo.