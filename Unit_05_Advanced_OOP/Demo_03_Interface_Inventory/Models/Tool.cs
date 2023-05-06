using Demo_03_Interface_Inventory.Interfaces;

namespace Demo_03_Interface_Inventory.Models;

class Tool : ICollectable
{
    public Player Owner { get; set; }
    public string ItemName { get; set; }

    private int quantity;

    public int Quantity
    {
        get { return quantity; }
        set 
        { 
            quantity = value;

            if (quantity <= 0) Owner.Inventory.AllItems.Remove(this);
        }
    }

    public int EnergyConsumptionPerUse { get; set; } = 5;

    public float Durability { get; set; } = 1.0f;

    public float UseDamage { get; set; } = 0.05f;

    public string UseMessage => $"{Owner.Name} used {ItemName}";

    public string GetInfo()
    {
        return $"{ItemName}, Quantity: {Quantity}, Durability: {Durability}";
    }

    public void Use()
    {
        if (Quantity > 0)
        {
            if (Owner.CurrentEnergyLevel >= EnergyConsumptionPerUse)
            {
                UseTool();
            }
            else
            {
                Denied();
            } 
        }
    }

    private void UseTool()
    {
        Durability -= UseDamage;

        Owner.CurrentEnergyLevel -= EnergyConsumptionPerUse;

        if (Durability < 0) Quantity--;

        Owner.ActionLog.Add(UseMessage);
    }

    private void Denied()
    {
        Owner.ActionLog.Add($"Not enough energy to use {ItemName}");
    }
}
