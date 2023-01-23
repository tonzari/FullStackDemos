using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExamples
{
    // These methods can be called from Program.cs 
    // Usage: 
    // string somePhoneNum = MethodReview.GetPhoneNumber();

    public static class MethodReview
    {
        // Methods -- note: declaring methods HERE will cause them to be 'local functions' to the Program class. Normally, please write your methods in a separate class, in a separate file.

        // Naming convention for Methods: PascalCase()
        // Generally, method names are VerbNoun to express what the method does: like TryParse, WriteLine, GetNames, DisplayTask, ReadLine, UpdateEmailAddress, SetColor

        public static void MakeGreen()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("The console? It's green now");
        }

        public static string GetPhoneNumber() // 248-123-1431 734.123.12312 (555)131-1231
        {
            return "123-123-1234";
        }

        // Overloading a method. Notice the Method name is the SAME, but now it has parameters
        public static string GetPhoneNumber(string firstName, string lastName)
        {
            // checks database for a match of both first and lastname

            return $"found phone number of {firstName} {lastName}: 1231231234";
        }

        public static string GetPhoneNumber(int userId)
        {
            // checks database for a match of userId
            if (userId == 7)
            {
                return "found phone number: 1231231233";
            }

            return "user not found";
        }
    }
}
