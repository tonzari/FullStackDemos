using Demo_03_Interface_Inventory.Interfaces;

namespace Demo_03_Interface_Inventory.Models;

class Player
{
    public List<string> PlayerActionLog { get; set; }       // Everytime the player 'uses' an inventory item, let's store the message associated with the action

    public List<ICollectable> Inventory { get; set; }       // In the constructor, we will set a default inventory for the player to start with

    public string PlayerName { get; set; }


    public Player(string playerName)
    {
        PlayerActionLog = new List<string>();
        Inventory = new List<ICollectable>()
            {
                new EdibleFood() { ItemName = "apple", EnergyProvided = 10, Quantity = 5, Owner = this },
                new EdibleFood() { ItemName = "banana", EnergyProvided = 15, Quantity = 5, Owner = this },
                new UnedibleFood { ItemName = "salt", EnergyProvided = 1, Quantity = 5, Owner = this },
                new Material { ItemName = "clay", Quantity = 5, Owner = this },
                new Material { ItemName = "wood", Quantity = 5, Owner = this },
                new Tool { ItemName = "axe", Quantity = 1, Durability = 1.0f, Owner = this}
            };
        PlayerName = playerName;
    }

}