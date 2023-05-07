using Demo_03_Interface_Inventory.Interfaces;
using Demo_03_Interface_Inventory.Models.Collectables;

namespace Demo_03_Interface_Inventory.Models
{
    internal class Inventory
    {
        private List<ICollectable> AllItems { get; set; }
        public IInventoryHolder Owner { get; set; }

        public Inventory(IInventoryHolder inventoryHolder)
        {
            AllItems = new List<ICollectable>()
            {
                new ConsumableFood() { ItemName = "apple", EnergyProvided = 5, Quantity = 3, Owner = inventoryHolder },
                new ConsumableFood() { ItemName = "banana", EnergyProvided = 10, Quantity = 2, Owner = inventoryHolder },
                new ConsumableFood() { ItemName = "whole baked chicken", EnergyProvided = 15, Quantity = 1, Owner = inventoryHolder },
                new RawIngredient() { ItemName = "salt", EnergyProvided = 1, Quantity = 2, Owner = inventoryHolder },
                new RawIngredient() { ItemName = "cayenne pepper", EnergyProvided = 2, Quantity = 1, Owner = inventoryHolder },
                new Material { ItemName = "clay", Quantity = 5, Owner = inventoryHolder },
                new Material { ItemName = "wood", Quantity = 5, Owner = inventoryHolder },
                new Tool { ItemName = "axe", Quantity = 1, Durability = 1.0f, Owner = inventoryHolder }
            };
        }

        public List<ICollectable> GetAllItems()
        {
            return AllItems;
        }

        public void RemoveItem(ICollectable itemToRemove)
        {
            AllItems.Remove(itemToRemove);
        }

        public void AddItem(ICollectable itemToAdd)
        {
            AllItems.Add(itemToAdd);
        }
    }
}
