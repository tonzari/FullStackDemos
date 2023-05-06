using Demo_03_Interface_Inventory.Interfaces;

namespace Demo_03_Interface_Inventory.Models;

class EdibleFood : Food, IEdible
{

    public override Player Owner { get; set; }

    public override string UseMessage
    {
        get { return $"{Owner.PlayerName} ate {ItemName}"; }
    }

    public void Eat()
    {
        Quantity--;
        Owner.PlayerActionLog.Add(UseMessage);

        if (Quantity <= 0) Owner.Inventory.Remove(this);
    }

    public override string GetInfo()
    {
        return $"{ItemName}, Quantity: {Quantity}, Energy: {EnergyProvided}";
    }

    public override void Use()
    {
        if (Quantity > 0)
        {
            Eat();
        }
    }
}