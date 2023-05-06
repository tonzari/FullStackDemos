using Demo_03_Interface_Inventory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03_Interface_Inventory.Models
{
    internal class Inventory
    {
        public List<ICollectable> AllItems { get; set; }
        public Player Owner { get; set; }

        public Inventory(Player player) 
        {
            AllItems = new List<ICollectable>()
            {
                new EdibleFood() { ItemName = "apple", EnergyProvided = 10, Quantity = 5, Owner = player },
                new EdibleFood() { ItemName = "banana", EnergyProvided = 15, Quantity = 5, Owner = player },
                new EdibleFood() { ItemName = "whole baked chicken", EnergyProvided = 15, Quantity = 5, Owner = player },
                new UnedibleFood { ItemName = "salt", EnergyProvided = 1, Quantity = 5, Owner = player },
                new Material { ItemName = "clay", Quantity = 5, Owner = player },
                new Material { ItemName = "wood", Quantity = 5, Owner = player },
                new Tool { ItemName = "axe", Quantity = 1, Durability = 1.0f, Owner = player}
            };
        }
    }
}
