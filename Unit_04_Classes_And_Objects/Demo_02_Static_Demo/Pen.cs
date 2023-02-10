using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02_Static_Demo
{
    public class Pen
    {
        public Pen(string inkColor)
        {
            InkColor = inkColor;
            InkLevel = 1.0f;

            AllPens.Add(this);
        }

        public string InkColor { get; set; }
        public string Brand { get; set; }
        public string InkType { get; set; }
        public decimal Price { get; set; }
        public float Length { get; set; } // this is an auto-property

        // Full Property below (both private inkLevel and public InkLevel) : https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
        // InkLevel: Range from 0 - 1... so 0.5 means about half of the ink is left

        private float inkLevel;
        public float InkLevel
        {
            get 
            {
                return inkLevel;
            }
            set
            {
                if (value > 1.0f)
                {
                    inkLevel = 1.0f;
                }
                else if(value < 0.0f)
                {
                    inkLevel = 0.0f;
                }
                else
                {
                    inkLevel = value;
                }
            }
        } 

        public void Write()
        {
            InkLevel -= 0.1f;
            Console.WriteLine("Pen Write() called!");
            Console.WriteLine("Ink leve: " + InkLevel * 100 + "%");
        }

        public static void RefillPens()
        {
            foreach (Pen pen in AllPens)
            {
                pen.InkLevel = 1.0f;
            }
        }

        public static List<Pen> AllPens = new List<Pen>() { };

    }
}
