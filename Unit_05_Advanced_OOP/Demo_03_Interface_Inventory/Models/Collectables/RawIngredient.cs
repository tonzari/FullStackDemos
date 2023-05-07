using Demo_03_Interface_Inventory.Interfaces;

namespace Demo_03_Interface_Inventory.Models.Collectables;

class RawIngredient : Food
{
    public override IInventoryHolder Owner { get; set; }

    public override string UseMessage => $"{Owner.Name} added {ItemName} to soup"; // An example of how a raw ingredient could be "used" as it is not edible alone.

    public void Cook()
    {
        Owner.ActionLog.Add(UseMessage);
        Quantity--;
    }

    public override string GetInfo()
    {
        return $"{ItemName}, Quantity: {Quantity}, Energy: {EnergyProvided}";
    }

    public override void Use()
    {
        if (Quantity > 0)
        {
            Cook();
        }
    }
}