using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03_With_Inheritance
{
   
    class Animal  // Base class (parent) 
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child)
    {
        public override void AnimalSound()
        {
            Console.WriteLine("oink");
        }
    }

    class Dog : Animal  // Derived class (child)
    {
        public override void AnimalSound()
        {
            Console.WriteLine("ruff");
        }
    }
}
