using Demo_03_Interface_Inventory.Interfaces;
using Demo_03_Interface_Inventory.Models;

Console.Write("Welcome to the Player Inventory / C# Interfaces demo! Enter Player name: ");
string userName = Console.ReadLine();
Player player = new Player(userName);

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

    Console.WriteLine("\nSelect an item in your inventory by number, and hit [enter] to use it: ");
    string userInput = Console.ReadLine();
    int userNum = int.Parse(userInput) - 1;

    if (player.Inventory.GetAllItems().Count > 0 && userNum < player.Inventory.GetAllItems().Count)                // Only allow a number within the bounds of the Inventory list
    {
        var itemSelected = player.Inventory.GetAllItems()[userNum];

        itemSelected.Use();
    }

} while (true);

