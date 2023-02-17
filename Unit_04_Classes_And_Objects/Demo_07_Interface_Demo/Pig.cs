using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_07_Interface_Demo
{
    public class Pig : IAnimal, IAdoptable
    {
        public string FavoriteFood { get; set; }

        public void Adopt()
        {
            Console.WriteLine("Tiny pig was adopted! Not really a tiny pig.");
        }

        public void AnimalSound()
        {
            Console.WriteLine("Oink");
        }

        public void Run()
        {
            Console.WriteLine("Pig ran!");
        }
    }
}
