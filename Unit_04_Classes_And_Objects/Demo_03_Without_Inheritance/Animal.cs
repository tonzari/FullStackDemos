using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03_Without_Inheritance
{
    /*    
    class Animal  // Base class (parent) 
    {
        public void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }*/

    class Pig
    {
        public void AnimalSound()
        {
            Console.WriteLine("oink");
        }
    }

    class Dog  
    {
        public void AnimalSound()
        {
            Console.WriteLine("ruff");
        }
    }
}
