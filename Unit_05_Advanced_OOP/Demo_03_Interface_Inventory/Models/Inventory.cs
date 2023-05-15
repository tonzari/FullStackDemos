using Demo_03_Interface_Inventory.Interfaces;
using Demo_03_Interface_Inventory.Models.Collectables;
using System.Runtime.CompilerServices;

namespace Demo_03_Interface_Inventory.Models
{
    internal class Inventory
    {
        private List<ICollectable> Items { get; set; } = new List<ICollectable>();
        public IInventoryHolder Owner { get; set; }

        public List<ICollectable> GetAllItems()
        {
            return Items;
        }

        public void RemoveItem(ICollectable itemToRemove)
        {
            Items.Remove(itemToRemove);
        }

        public void AddItem(ICollectable itemToAdd)
        {
            // Does the item already exist in the inventory?
            var result = Items.Find(i => i.ItemName == itemToAdd.ItemName);


            if (result != null)
            {
                // Then increase the quantity
                result.Quantity += itemToAdd.Quantity;
            }
            else
            {
                // Otherwise add the full item
                itemToAdd.Owner = Owner;
                Items.Add(itemToAdd);
            }
        }

        public void AddItems(List<ICollectable> items)
        {
            foreach (var item in items)
            {
                AddItem(item);
            }
        }
    }
}
