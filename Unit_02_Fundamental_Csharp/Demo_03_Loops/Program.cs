// Do While Demo: will run once, and may continue if condition is true.

// This Do While loop will run until the user provides valid input. In this case, any integer. 
// TODO: How might you validate that the user has provided a number in the correct range? [1-12]
bool isValidNum;

do
{
    Console.WriteLine("What is your birthday month as a number? ");
    string birthMonthNum = Console.ReadLine();

    isValidNum = int.TryParse(birthMonthNum, out int num);

    Console.WriteLine($"Parsed? {isValidNum} \n User Birth Month: {num} \n\n");

    if (num == 13)
        break; // This breaks out of the whole loop!

    if (isValidNum is not true) // another option in C#... you can write english!
        Console.WriteLine("Sorry, please enter an integer to proceed.");

} while (isValidNum == false);


// While Demo

while(false)
{
    // only runs if condition is true. it may never run.
    // make sure you have a way to break out of the loop!
    // otherwise you'll have an infinite loop that crashes.
}


// For Loop Review

// declare and initialize an integer
// set a condition
// set an iterator

for (int i = 50; i > 0; i -= 2)
{
    Console.WriteLine(i);
}