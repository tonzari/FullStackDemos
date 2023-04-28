namespace Demo_02_Simple_Mock_API.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> MenuItemIds { get; set; }
    }
}
