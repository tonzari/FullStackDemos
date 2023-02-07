// Introduction to classes
// Classes allow you to bundle data together, as well as logic
// Such as properties, fields, and methods

// Instantiated Classes

using Demo_01_Class_Intro;

MenuItem myFirstItem = new MenuItem();

myFirstItem.Name = "Coney Dog";
myFirstItem.Description = "A Coney Island hot dog, Coney dog, or Coney is a hot dog in a bun topped with a savory meat sauce and sometimes other toppings.";
myFirstItem.Price = 2.50m;

//Console.WriteLine("myFirstItem name: " + myFirstItem.Name);

MenuItem mySecondItem = new MenuItem();

mySecondItem.Name = "Chili Dog";
mySecondItem.Description = "Basically a coney dog with chili on it, I don't know!";
mySecondItem.Price = 3.00m;

//Console.WriteLine("mySecondItem name: " + mySecondItem.Name);

// Let's create a new list and immediately add MenuItem objects to it
List<MenuItem> menu = new List<MenuItem>() 
{
    myFirstItem,
    mySecondItem,
    new MenuItem(){ Name = "Chili Cheese Dog", Price = 3.50m },
    new MenuItem(){ Name = "Corn Dog", Price = 2.75m },
    new MenuItem(){ Name = "Footlong Coney", Price = 4.00m },
    new MenuItem(){ Name = "Bacon Cheddar Dog", Price = 4.25m }
};


Console.WriteLine("Here is our menu: \n");

foreach (MenuItem menuItem in menu)
{
    Console.WriteLine($"{menuItem.Name}, {menuItem.Price}");
    Console.WriteLine($"{menuItem.Description}");
    Console.WriteLine();
}

do
{
    Console.WriteLine("Add a new item to our menu... \n");

    Console.WriteLine("Name: ");
    string userItemName = Console.ReadLine();

    Console.WriteLine("Price: ");
    string userItemPriceString = Console.ReadLine();
    decimal userItemPrice = decimal.Parse(userItemPriceString);

    Console.WriteLine("Description: ");
    string userDescription = Console.ReadLine();

    Console.WriteLine("Calories: ");
    string userItemCaloriesString = Console.ReadLine();
    int userCalories = int.Parse(userItemCaloriesString);

    MenuItem userMenuItem = new MenuItem();
    userMenuItem.Name = userItemName;
    userMenuItem.Price = userItemPrice;
    userMenuItem.Description = userDescription;
    userMenuItem.Calories = userCalories;

    menu.Add(userMenuItem);

    Console.WriteLine("Add another item?");
} while (Console.ReadLine() == "y");

Console.WriteLine("Updated menu: \n");

foreach (MenuItem menuItem in menu)
{
    Console.WriteLine($"{menuItem.Name}, {menuItem.Price}");
    Console.WriteLine($"{menuItem.Description}");
    if (menuItem.Calories <= 0)
    {
        Console.WriteLine($"{menuItem.Calories}");
    }
    Console.WriteLine();
}