using Demo_03_Interface_Inventory.Models;

namespace Demo_03_Interface_Inventory.Interfaces;

interface ICollectable
{
    Player Owner { get; set; }
    string ItemName { get; set; }
    string UseMessage { get; }
    int Quantity { get; set; }
    string GetInfo();
    void Use();
}