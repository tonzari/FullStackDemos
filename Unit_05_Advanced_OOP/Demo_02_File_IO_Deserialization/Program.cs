// File IO Serialization + Deserialization
// Our goal: Create a text file that we can write to.
//           We also want to read the text file back into our app.
//           We want to create our own class: InventoryItem
//           We will create lists of InventoryItems
//           We will save those objects to a text file, and then read them back from the text file.

// docs: https://learn.microsoft.com/en-us/dotnet/api/system.io.file?view=net-6.0
// How to check OS during runtime: https://mariusschulz.com/blog/detecting-the-operating-system-in-net-core

using Demo_02_File_IO_Deserialization;
using System.Runtime.InteropServices;

// Define path based on OS

string macPath = @"/Users/YourUserName/Desktop/Inventory.txt";
string windowsPath = @"c:\Users\dude_dude\Desktop\Inventory.txt";
string path = string.Empty;

// Detect the Operating system

if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
{
    Console.WriteLine("Windows!");
    path = windowsPath;
}

if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
{
    Console.WriteLine("Mac!");
    path = macPath;
}

// Create an inventory item instance: hardcode example
InventoryItem inventoryItem = new InventoryItem("001", "Cat", "Friendly cat. Please buy.", 150.00m);

if (!File.Exists(path))
{
    // Prompt user to create their own inventory item

    Console.WriteLine("Create a new Inventory Item.");

    Console.WriteLine("ID: ");
    string userId = Console.ReadLine();

    Console.WriteLine("Name: ");
    string userName = Console.ReadLine();

    Console.WriteLine("Description: ");
    string userDescription = Console.ReadLine();

    Console.WriteLine("Price: ");
    decimal userPrice = decimal.Parse(Console.ReadLine());

    InventoryItem userInventoryItem = new InventoryItem(userId, userName, userDescription, userPrice);


    // Create a file to write to.
    using (StreamWriter sw = File.CreateText(path))
    {
        sw.WriteLine(inventoryItem);
        sw.WriteLine(userInventoryItem);
    }
}

// Open the file to read from.

Console.WriteLine("Print out the exact content of the text file:");
using (StreamReader sr = File.OpenText(path))
{
    string s;
    while ((s = sr.ReadLine()) != null)
    {
        Console.WriteLine(s);
    }
}

// How do we turn the text file back into OBJECTS in our program? 
// We want to turn a string into an object. 
// This is known as DESERIALIZATION.

List<InventoryItem> inventoryItems = new List<InventoryItem>();

using (StreamReader sr = File.OpenText(path))
{
    string s;
    while ((s = sr.ReadLine()) != null)
    {
        string[] values = s.Split("||");

        decimal priceFromFile = decimal.Parse(values[3]);

        InventoryItem itemFromFile = new InventoryItem(values[0], values[1], values[2], priceFromFile);
        inventoryItems.Add(itemFromFile);
    }
}

// Loop through the deserialized objects
foreach (InventoryItem item in inventoryItems)
{
    Console.WriteLine($"{item.ProductName} is {item.Price}.");
}
