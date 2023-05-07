using Demo_03_Interface_Inventory.Interfaces;

namespace Demo_03_Interface_Inventory.Models.Collectables;

class ConsumableFood : Food, IEdible
{

    public override IInventoryHolder Owner { get; set; }

    public override string UseMessage
    {
        get { return $"{Owner.Name} ate {ItemName}"; }
    }

    public void Eat()
    {
        Quantity--;
        Owner.CurrentEnergyLevel += EnergyProvided;
        Owner.ActionLog.Add(UseMessage);

        if (Quantity <= 0) Owner.Inventory.RemoveItem(this);
    }

    public override string GetInfo()
    {
        return $"{ItemName}, Quantity: {Quantity}, Energy: {EnergyProvided}, (edible!)";
    }

    public override void Use()
    {
        if (Quantity > 0)
        {
            Eat();
        }
    }
}