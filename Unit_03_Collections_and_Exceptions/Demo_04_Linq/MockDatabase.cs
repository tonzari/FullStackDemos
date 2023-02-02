using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04_Linq
{
    static class MockDatabase
    {
        private static List<string> menuItems = new List<string>() {
            "Coney Dog",
            "Chili Dog",
            "Chili Cheese Dog",
            "Corn Dog",
            "Footlong Coney",
            "Bacon Cheddar Dog",
            "Cheese Coney",
            "Grilled Cheese Dog",
            "Onion Rings",
            "French Fries",
            "Cheese Fries",
            "Chili Fries",
            "Mozzarella Sticks",
            "Jalapeno Poppers",
            "Nachos",
            "Soft Pretzel",
            "Cotton Candy",
            "Funnel Cake",
            "Ice Cream Cone",
            "Milkshake",
            "Root Beer Float"
        };

        private static Dictionary<string, decimal> menuPrices = new Dictionary<string, decimal>() {
            {"Coney Dog", 2.50m},
            {"Chili Dog", 3.00m},
            {"Chili Cheese Dog", 3.50m},
            {"Corn Dog", 2.75m},
            {"Footlong Coney", 4.00m},
            {"Bacon Cheddar Dog", 4.25m},
            {"Cheese Coney", 3.25m},
            {"Grilled Cheese Dog", 2.75m},
            {"Onion Rings", 3.50m},
            {"French Fries", 2.00m},
            {"Cheese Fries", 3.00m},
            {"Chili Fries", 3.50m},
            {"Mozzarella Sticks", 4.00m},
            {"Jalapeno Poppers", 4.00m},
            {"Nachos", 5.00m},
            {"Soft Pretzel", 2.50m},
            {"Cotton Candy", 1.50m},
            {"Funnel Cake", 4.00m},
            {"Ice Cream Cone", 2.00m},
            {"Milkshake", 4.00m},
            {"Root Beer Float", 3.00m}
        };


        public static List<string> GetAllMenuItems() { return menuItems; }
        public static Dictionary<string, decimal> GetMenuWithPrices() { return menuPrices; }
    }
}
