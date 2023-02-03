
// Debugging Demo
/*
using Demo_05_DebugAndExceptions;

int age = 35;
string name = "Benny";
bool isEmpolyeed = true;

UselessMethod();

Console.WriteLine(age);
Console.WriteLine(name);
Console.WriteLine(isEmpolyeed);

string result = Methods.GetUserName(123);
Console.WriteLine(result);
void UselessMethod()
{
    int num = 10;
    num++;
    Console.WriteLine(num);
}

Console.WriteLine("\n\n");

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(i*j);
    }

    Console.WriteLine();
}

*/

// 000000000000
// 111111111111
// 222222222222
// 333333333333
// ....

// Exceptions Demo

// example of an exception

int[] numArray = { 1, 23, 45 };

Console.WriteLine(numArray[1]);


// Console.WriteLine(numArray[3]); // this line causes an exception to be thrown

// What if we want to prevent the program from stopping?

try
{
    Console.WriteLine(numArray[3]);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("The program continues...");

// Exercise!

// 1 Get two numbers from the user
// 2 Then divide the first number by the second number
// 3 Set up a try catch to ensure that no exceptions are thrown.
// 4 Print out the exception's message, or anyother exception info that you'd like to print.

// A Try Catch can be autocompleted with 'try' tab tab, or highlight code, right click / Snippet / Surround with... / Select try

// NOTE: "Dividing a floating-point value by zero doesn't throw an exception; it results in positive infinity, negative infinity, or not a number (NaN), according to the rules of IEEE 754 arithmetic."
// from: https://learn.microsoft.com/en-us/dotnet/api/system.dividebyzeroexception?view=net-6.0

/*int a = 5;
int b = 0;

try
{
    int result = a / b;
    Console.WriteLine("answer: " + result);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
*/

decimal decimal1 = 5.25m;
decimal decimal2 = 0;

try
{
    decimal result = decimal1 / decimal2;
    Console.WriteLine("answer: " + result);
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.Message);
}
catch(OutOfMemoryException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

    Console.WriteLine("exiting...");
    Environment.Exit(0);
}
finally
{
    Console.WriteLine("Always runs!");
}