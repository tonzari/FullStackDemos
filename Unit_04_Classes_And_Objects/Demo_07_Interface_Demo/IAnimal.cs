using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_07_Interface_Demo
{
    interface IAnimal
    {
        string FavoriteFood { get; set; }
        void AnimalSound();
        void Run();
    }
}
