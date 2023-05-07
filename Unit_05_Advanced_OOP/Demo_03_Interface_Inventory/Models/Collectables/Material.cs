using Demo_03_Interface_Inventory.Interfaces;

namespace Demo_03_Interface_Inventory.Models.Collectables;

class Material : ICollectable
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

            if (Quantity <= 0) Owner.Inventory.RemoveItem(this);
        }
    }

    public string UseMessage => $"{Owner.Name} built something with {ItemName}";

    public void Build()
    {
        Quantity--;
        Owner.ActionLog.Add(UseMessage);

        if (Quantity <= 0) Owner.Inventory.RemoveItem(this);
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