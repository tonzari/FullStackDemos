using Demo_03_Interface_Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03_Interface_Inventory.Interfaces
{
    internal interface IInventoryHolder
    {
        public Inventory Inventory { get; set; }
        public List<string> ActionLog { get; set; }

        public string Name { get; set; }
        public int CurrentEnergyLevel { get; set; }

    }
}
