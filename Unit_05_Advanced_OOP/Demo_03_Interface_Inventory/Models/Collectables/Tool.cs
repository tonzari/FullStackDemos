using Demo_03_Interface_Inventory.Interfaces;

namespace Demo_03_Interface_Inventory.Models.Collectables;

class Tool : ICollectable, IBreakable
{
    public IInventoryHolder Owner { get; set; }
    public string ItemName { get; set; }

    private int quantity;

    public int Quantity
    {
        get { return quantity; }
        set
        {
            quantity = value;

            if (quantity <= 0) Owner.Inventory.RemoveItem(this);
        }
    }

    public int EnergyConsumptionPerUse { get; set; } = 5;


    private float durability = 1.0f;
    public float Durability
    {
        get
        {
            return durability;
        }
        set
        {
            durability = value;

            if (durability < 0)
            {
                Quantity--;
                durability = 1.0f;
            }
        }
    }

    public float UseDamage { get; set; } = 0.1f;

    public string UseMessage
    {
        get
        {
            if (durability < 0)
            {
                return BreakMessage;
            }

            return $"{Owner.Name} used {ItemName}";
        }
    }

    public string BreakMessage => $"{Owner.Name} broke {ItemName}";

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
                DenyUse();
            }
        }
    }

    private void UseTool()
    {
        Durability -= UseDamage;

        Owner.CurrentEnergyLevel -= EnergyConsumptionPerUse;

        Owner.ActionLog.Add(UseMessage);
    }

    private void DenyUse()
    {
        Owner.ActionLog.Add($"Not enough energy to use {ItemName}");
    }
}
