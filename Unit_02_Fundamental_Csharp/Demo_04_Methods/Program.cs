using Demo_04_Methods;


string input = string.Empty;

Console.WriteLine("Weclome to the Method Demo!");
do
{
    // Methods

    //Console.WriteLine("Console Writeline"); // You've been using methods all along! See how Console.WriteLine() is similar to MyFirstMethods.GreetPerson() below?
    MyFirstMethods.GreetPerson();

    // return types in methods

    int sum = MyFirstMethods.Add(5, 10); // This method returns an integer. To make use of that returned int, we should do something with it! Let's store it in a variable and then print it out.

    Console.WriteLine(sum);

    Console.WriteLine("Type in a word. The computer will determine if the word is less than five characters long...");
    input = Console.ReadLine(); // ReadLine() returns a string. It provides a string for you do what you want with it.
    bool result = MyFirstMethods.IsLessThanFiveChars(input); // This method evaulates whether or not the provided string is less than five characters long. The method willr return a bool: true or false.
    Console.WriteLine(result);


    MyFirstMethods.CallAllTheMethods(); // This method doesn't take any arguments, nor does it return anything. It just contains a sequence of instructions. In this case it runs a collection of methods in the MyFirstMethods class.

    Console.WriteLine(MyFirstMethods.Add(123, 123));

    Console.WriteLine("Run again? y/n");
    input = Console.ReadLine();

} while (input.Equals("y"));




// Random class
Random rand = new Random(); // only make one!

for (int i = 0; i < 5; i++)
{
    int myRandomNum = rand.Next(1, 7);
    Console.WriteLine(myRandomNum);
}

int firstNum = rand.Next(100);
int secondNum = rand.Next(100);
Console.WriteLine($"{firstNum}, {secondNum}");