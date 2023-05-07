using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03_Interface_Inventory.Interfaces
{
    interface IBreakable
    {
        public float Durability { get; set; }

        public float UseDamage { get; set; }
        public string BreakMessage { get; }
    }
}
