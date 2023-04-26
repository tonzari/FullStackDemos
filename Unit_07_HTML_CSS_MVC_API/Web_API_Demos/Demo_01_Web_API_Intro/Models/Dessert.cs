namespace Demo_01_Web_API_Intro.Models
{
    public class Dessert
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DessertType { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }

        public Dessert(string name, string dessertType, decimal price, bool available)
        {         
            Id = DessertCount;
            Name = name;
            DessertType = dessertType;
            Price = price;
            Available = available;

            DessertCount++;
        }

        public static int DessertCount;

        // This will serve as our Mock database. This is a very simplified way of setting up some dummy data so we can practice Web API.
        // In a more advanced demo, you might create a custom class library that provides data models and database access.
        // Because it is marked 'static', it is accessible to the rest of the application, and for example, can accessed like this: List<Desserts> allDesserts = Dessert.Desserts;
        public static List<Dessert> Desserts = new List<Dessert>
        {
            new Dessert("Chocolate Cake", "Cake", 10.50m, true),
            new Dessert("Strawberry Cheesecake", "Cheesecake", 12.00m, true),
            new Dessert("Lemon Tart", "Tart", 8.25m, true),
            new Dessert("Apple Pie", "Pie", 9.75m, false),
            new Dessert("Vanilla Ice Cream", "Ice Cream", 4.50m, true),
            new Dessert("Chocolate Chip Cookie", "Cookie", 1.50m, true),
            new Dessert("Blueberry Muffin", "Muffin", 2.75m, true),
            new Dessert("Tiramisu", "Cake", 11.00m, true),
            new Dessert("Pecan Pie", "Pie", 10.00m, false),
            new Dessert("Carrot Cake", "Cake", 10.50m, true),
            new Dessert("Raspberry Sorbet", "Sorbet", 4.00m, true),
            new Dessert("Creme Brulee", "Custard", 6.50m, true),
            new Dessert("Brownie", "Bar", 2.00m, true),
            new Dessert("Peanut Butter Cookie", "Cookie", 1.75m, true),
            new Dessert("Red Velvet Cake", "Cake", 11.50m, false),
            new Dessert("Key Lime Pie", "Pie", 9.50m, true),
            new Dessert("Banana Bread", "Bread", 7.00m, true),
            new Dessert("Black Forest Cake", "Cake", 12.00m, true),
            new Dessert("Mango Ice Cream", "Ice Cream", 4.75m, true),
            new Dessert("Chocolate Eclair", "Pastry", 3.50m, true),
            new Dessert("Oatmeal Raisin Cookie", "Cookie", 1.50m, true),
            new Dessert("Pumpkin Pie", "Pie", 9.00m, false),
            new Dessert("Cupcake", "Cupcake", 2.50m, true),
            new Dessert("Bread Pudding", "Pudding", 6.00m, true),
            new Dessert("Gelato", "Ice Cream", 4.25m, true)
        };
    }
}
