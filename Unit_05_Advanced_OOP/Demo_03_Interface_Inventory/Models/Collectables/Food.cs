using Demo_03_Interface_Inventory.Interfaces;

namespace Demo_03_Interface_Inventory.Models.Collectables;

abstract class Food : ICollectable
{
    public abstract IInventoryHolder Owner { get; set; }
    public int EnergyProvided { get; set; }
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

    public abstract string UseMessage { get; }

    public abstract string GetInfo();

    public virtual void Use() { }
}