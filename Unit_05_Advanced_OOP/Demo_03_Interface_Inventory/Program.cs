using Demo_03_Interface_Inventory.Interfaces;
using Demo_03_Interface_Inventory.Models;

CollectablesFactory colletableFactory = new CollectablesFactory();

Console.Write("Welcome to the Player Inventory / C# Interfaces demo! Enter Player name: ");

string userName = Console.ReadLine();
Player player = new Player(userName);
player.Inventory.AddItems(colletableFactory.GetRandomCollectables(5));

do
{
    Console.Clear();
    Console.WriteLine("\nPlayer inventory - - - - - - - - - - - - - - - -");          // Print out full player Inventory
    Console.WriteLine("\nPlayer Energy: " + player.CurrentEnergyLevel + "\n");
    
    for (int i = 0; i < player.Inventory.GetAllItems().Count; i++)
    {
        Console.Write(i + 1 + ". " + player.Inventory.GetAllItems()[i].GetInfo() + "\n");
    }

    Console.WriteLine("\nAction Log - - - - - - - - - - - - - - - - - - - -\n");        // Print out entire Player Action history

    foreach (string playerAction in player.ActionLog)
    {
        Console.WriteLine(playerAction);
    }

    Console.WriteLine("\nPress 0 to get a new random item.\nSelect an item in your inventory by number, and hit [enter] to use it: ");
    
    string userInput = Console.ReadLine();
    int userNumChoice = int.Parse(userInput);
    int userNumZeroBased = userNumChoice - 1;

    if (userNumChoice == 0)
    {
        // Get random collectable
        ICollectable randomItem = colletableFactory.GetRandomCollectable();

        // Add to player's inventory
        player.Inventory.AddItem(randomItem);

    } 
    else if (player.Inventory.GetAllItems().Count > 0 && userNumZeroBased < player.Inventory.GetAllItems().Count)                // Only allow a number within the bounds of the Inventory list
    {
        var itemSelected = player.Inventory.GetAllItems()[userNumZeroBased];

        itemSelected.Use();
    }


} while (true);

