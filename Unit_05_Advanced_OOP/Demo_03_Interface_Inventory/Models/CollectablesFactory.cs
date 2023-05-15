using Demo_03_Interface_Inventory.Interfaces;
using Demo_03_Interface_Inventory.Models.Collectables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03_Interface_Inventory.Models
{
    class CollectablesFactory
    {
        public List<ICollectable> AllCollectables { get; set; }

        Random random = new Random();

        public CollectablesFactory() 
        {
            AllCollectables = new List<ICollectable>()
            {
                new ConsumableFood() { ItemName = "apple", EnergyProvided = 5, Quantity = 1, Owner = null },
                new ConsumableFood() { ItemName = "banana", EnergyProvided = 10, Quantity = 1, Owner = null },
                new ConsumableFood() { ItemName = "whole baked chicken", EnergyProvided = 15, Quantity = 1, Owner = null },
                new RawIngredient() { ItemName = "salt", EnergyProvided = 1, Quantity = 1, Owner = null },
                new RawIngredient() { ItemName = "cayenne pepper", EnergyProvided = 2, Quantity = 1, Owner = null },
                new Material { ItemName = "clay", Quantity = 1, Owner = null },
                new Material { ItemName = "wood", Quantity = 1, Owner = null },
                new Tool { ItemName = "axe", EnergyConsumptionPerUse = 3, Quantity = 1, Durability = 1.0f, Owner = null }
            };
        }

        public ICollectable GetRandomCollectable() 
        {
            int randomInt = random.Next(0, 4);

            switch (randomInt)
            {
                case 0:
                    return GetRandomConsumableFood(); 
                    break;
                case 1:
                    return GetRandomMaterial();
                    break;
                case 2:
                    return GetRandomRawIngredient();
                    break;
                case 3:
                    return GetRandomTool();
                default:
                    return null;
                    break;
            }


        }

        public List<ICollectable> GetRandomCollectables(int count = 3)
        {
            var result = new List<ICollectable>();

            for (int i = 0; i < count; i++)
            {
                result.Add(GetRandomCollectable());
            }

            return result;
        }

        private ConsumableFood GetRandomConsumableFood()
        {
            var results = AllCollectables.Where(i => i.GetType() == typeof(ConsumableFood)).ToList();

            int randomInt = random.Next(0, results.Count);

            ConsumableFood randomConsumableFoodRef = results[randomInt] as ConsumableFood;

            ConsumableFood consumableFood = new ConsumableFood();

            consumableFood.ItemName = randomConsumableFoodRef.ItemName;
            consumableFood.EnergyProvided = randomConsumableFoodRef.EnergyProvided;
            consumableFood.Quantity = randomConsumableFoodRef.Quantity;

            return consumableFood;
        }

        private Material GetRandomMaterial()
        {
            var results = AllCollectables.Where(i => i.GetType() == typeof(Material)).ToList();

            int randomInt = random.Next(0, results.Count);

            Material randomMasterialRef = results[randomInt] as Material;

            Material material = new Material();

            material.ItemName = randomMasterialRef.ItemName;
            material.Quantity = randomMasterialRef.Quantity;

            return material;
        }

        private RawIngredient GetRandomRawIngredient()
        {
            var results = AllCollectables.Where(i => i.GetType() == typeof(RawIngredient)).ToList();

            int randomInt = random.Next(0, results.Count);

            RawIngredient randomRawingredientRef = results[randomInt] as RawIngredient;

            RawIngredient rawIngredient = new RawIngredient();

            rawIngredient.ItemName = randomRawingredientRef.ItemName;
            rawIngredient.EnergyProvided = randomRawingredientRef.EnergyProvided;
            rawIngredient.Quantity = randomRawingredientRef.Quantity;

            return rawIngredient;
        }

        private Tool GetRandomTool()
        {
            var results = AllCollectables.Where(i => i.GetType() == typeof(Tool)).ToList();

            int randomInt = random.Next(0, results.Count);

            Tool randomToolRef = results[randomInt] as Tool;

            Tool tool = new Tool();

            tool.ItemName = randomToolRef.ItemName;
            tool.Durability = randomToolRef.Durability;
            tool.EnergyConsumptionPerUse = randomToolRef.EnergyConsumptionPerUse;
            tool.Quantity = randomToolRef.Quantity;

            return tool;
        }



    }
}
