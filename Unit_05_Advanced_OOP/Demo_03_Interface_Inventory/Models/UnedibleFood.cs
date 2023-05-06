using Demo_03_Interface_Inventory.Interfaces;

namespace Demo_03_Interface_Inventory.Models;

// This class is for food that is not in an edible state such as raw ingredients: salt, sugar, cooking oil, raw pork, etc.
// It can however be "used", and for now that means "cooked"
class UnedibleFood : Food, ICookable
{
    public override Player Owner { get; set; }

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