using Demo_03_Interface_Inventory.Interfaces;

namespace Demo_03_Interface_Inventory.Models;

class NPC : IInventoryHolder
{
    public List<string> ActionLog { get; set; }
    public Inventory Inventory { get; set; }
    public string Name { get; set; }
    public int CurrentEnergyLevel { get; set; }

    public NPC(string npcName)
    {
        Name = npcName;
        Inventory = new Inventory(this);
        ActionLog = new List<string>();
    }
}