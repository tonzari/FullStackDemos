using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_05_Enums
{
    public class Person
    {
        public string FirstName { get; set; }
        public CurrentState State { get; set; } // Adding an enum as a property
    }
}

