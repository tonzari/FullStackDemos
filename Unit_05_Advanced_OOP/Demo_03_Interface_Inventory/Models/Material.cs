using Demo_03_Interface_Inventory.Interfaces;

namespace Demo_03_Interface_Inventory.Models;

class Material : ICollectable
{
    public string ItemName { get; set; }
    private int quantity;
    public int Quantity
    {
        get { return quantity; }
        set
        {
            quantity = value;
            if (Quantity <= 0) Owner.Inventory.AllItems.Remove(this);
        }
    }

    public Player Owner { get; set; }

    public string UseMessage => $"{Owner.Name} built something with {ItemName}";

    public void Build()
    {
        Quantity--;
        Owner.ActionLog.Add(UseMessage);

        if (Quantity <= 0) Owner.Inventory.AllItems.Remove(this);
    }

    public void Use()
    {
        if (Quantity > 0)
        {
            Build();
        }

    }

    public string GetInfo()
    {
        return $"{ItemName}, Quantity: {Quantity}";
    }
}