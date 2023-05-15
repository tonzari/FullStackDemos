using Demo_03_Interface_Inventory.Interfaces;

namespace Demo_03_Interface_Inventory.Models;

class NPC : IInventoryHolder
{
    public List<string> ActionLog { get; set; } = new List<string>();
    public Inventory Inventory { get; set; } = new Inventory();
    public string Name { get; set; }
    public int CurrentEnergyLevel { get; set; }

    public NPC(string npcName)
    {
        Name = npcName;
    }
}