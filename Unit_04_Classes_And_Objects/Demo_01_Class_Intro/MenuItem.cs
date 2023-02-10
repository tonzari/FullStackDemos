/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01_Class_Intro
{
    // Think of this as a blueprint
    public class MenuItem
    {
        public string Name;
        private decimal price;
        public string Description;
        public int Calories;
        public List<string> Ingredients;

        public decimal GetPrice() { return price; }
        public void SetPrice(decimal price)
        {
            // run som sort of special logic
            Description = Description + "\n Price changed on " + DateTime.Now.ToString();

            this.price = price;
        }

        public string GetFullDescription()
        {
            return $"{Name}, {GetPrice()}, {Description}, {Calories}";
        }

        // Constructor.
        // This initializes your new instance. It allows you to set default values
        // and run logic if needed.
        public MenuItem(string name, decimal price, int calories, string description = "No description")
        {
            Name = name;
            this.price = price;
            Description = description;
            Calories = calories;
            Ingredients = new List<string>(); // Default value will be an instantiated List ready to be added to
        }
    }
}
*/