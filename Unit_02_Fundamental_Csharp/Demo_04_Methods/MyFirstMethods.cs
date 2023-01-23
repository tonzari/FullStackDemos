using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04_Methods
{
    public static class MyFirstMethods
    {
        public static void GreetPerson()
        {
            Console.WriteLine("Hello, Person!");
            Console.WriteLine("Hope you are well.");
        }

        public static int Add(int x, int y)
        {
            int result = x + y;
            return result;
        }

        public static string MyMessage(int x)
        {
            if (x > 5)
            {
                return "hurray greater than 5!";
            }

            return "nope";
        }

        public static bool IsLessThanFiveChars(string input)
        {
            if (input.Length < 5)
            {
                return true;
            }

            return false;
        }

        public static void CallAllTheMethods()
        {
            Console.WriteLine("Entered CallAllTheMethods...");
            Console.WriteLine(Add(10, 5));
            Console.WriteLine(IsLessThanFiveChars("dog"));
        }
    }
}
