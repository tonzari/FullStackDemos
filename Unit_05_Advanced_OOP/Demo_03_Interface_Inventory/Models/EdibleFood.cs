using Demo_03_Interface_Inventory.Interfaces;

namespace Demo_03_Interface_Inventory.Models;

class EdibleFood : Food, IEdible
{

    public override Player Owner { get; set; }

    public override string UseMessage
    {
        get { return $"{Owner.Name} ate {ItemName}. Energy level is now {Owner.CurrentEnergyLevel}"; }
    }

    public void Eat()
    {
        Quantity--;
        Owner.CurrentEnergyLevel += this.EnergyProvided;
        Owner.ActionLog.Add(UseMessage);

        if (Quantity <= 0) Owner.Inventory.AllItems.Remove(this);
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