namespace Demo_02_Simple_Mock_API.Models
{
    public class CafeDb
    {
        public List<Menu> Menus { get; set; }
        public List<MenuItem> MenuItems { get; set; }

        public CafeDb()
        {
            MenuItems = new List<MenuItem>
            {
                new MenuItem { Id = 1, Name = "Espresso", Description = "Strong, rich coffee", Category = "Coffee", Price = 2.50m },
                new MenuItem { Id = 2, Name = "Cappuccino", Description = "Espresso with steamed milk and froth", Category = "Coffee", Price = 3.50m },
                new MenuItem { Id = 3, Name = "Croissant", Description = "Buttery, flaky pastry", Category = "Snacks", Price = 2.00m },
                new MenuItem { Id = 4, Name = "Bagel", Description = "Freshly baked bagel with cream cheese", Category = "Snacks", Price = 3.00m },
                new MenuItem { Id = 5, Name = "Latte", Description = "Smooth coffee with steamed milk", Category = "Coffee", Price = 3.50m },
                new MenuItem { Id = 6, Name = "Mocha", Description = "Rich coffee with chocolate and steamed milk", Category = "Coffee", Price = 4.00m },
                new MenuItem { Id = 7, Name = "Sandwich", Description = "Delicious sandwich with a variety of fillings", Category = "Snacks", Price = 6.00m },
                new MenuItem { Id = 8, Name = "Salad", Description = "Fresh and healthy salad", Category = "Snacks", Price = 7.00m },
            };

            Menus = new List<Menu>
            {
                new Menu
                {
                    Id = 1,
                    Name = "Breakfast Menu",
                    MenuItemIds = new List<int> { 1, 2, 5, 6, 3, 4 }
                },
                new Menu
                {
                    Id = 2,
                    Name = "Day Menu",
                    MenuItemIds = new List<int> { 1, 2, 5, 6, 7, 8 }
                }
            };
        }

    }
}
