using Demo_03_Interface_Inventory.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Demo_03_Interface_Inventory.Models;

class Player: IInventoryHolder
{
    public List<string> ActionLog { get; set; } = new List<string>();
    public Inventory Inventory { get; set; } = new Inventory();
    public string Name { get; set; }
    public int CurrentEnergyLevel { get; set; }

    public Player(string playerName)
    {
        Name = playerName;
        Inventory.Owner = this;
    }
}