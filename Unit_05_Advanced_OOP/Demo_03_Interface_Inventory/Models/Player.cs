﻿using Demo_03_Interface_Inventory.Interfaces;

namespace Demo_03_Interface_Inventory.Models;

class Player: IInventoryHolder
{
    public List<string> ActionLog { get; set; }       
    public Inventory Inventory { get; set; }
    public string Name { get; set; }
    public int CurrentEnergyLevel { get; set; }

    public Player(string playerName)
    {
        Name = playerName;
        Inventory = new Inventory(this);
        ActionLog = new List<string>();
    }
}