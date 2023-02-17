using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_06_Abstract_Demo
{
    abstract class Animal  // Base class (parent) Abstract classes cannot be instantiated. They MUST be inherited.
    {
        public abstract string Name { get; set; }

        public abstract void AnimalSound();
    }

    class Pig : Animal  // Derived class (child)
    {
        public override string Name { get; set; }

        public override void AnimalSound()  // Every child class must override the abstract members of the parent class
        {
            Console.WriteLine("oink");
        }
    }

    class Dog : Animal  // Derived class (child)
    {
        public override string Name { get; set; }
        public override void AnimalSound()
        {
            Console.WriteLine("ruff");
        }
    }
  
}
