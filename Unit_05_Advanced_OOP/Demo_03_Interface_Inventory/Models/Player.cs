using Demo_03_Interface_Inventory.Interfaces;

namespace Demo_03_Interface_Inventory.Models;

class Player
{
    public List<string> ActionLog { get; set; }       // Everytime the player 'uses' an inventory item, let's store the message associated with the action

    public Inventory Inventory { get; set; }       // In the constructor, we will set a default inventory for the player to start with

    public string Name { get; set; }
    public int CurrentEnergyLevel { get; set; }

    public Player(string playerName)
    {
        Name = playerName;
        Inventory = new Inventory(this);
        ActionLog = new List<string>();
    }

}