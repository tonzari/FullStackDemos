using System.Runtime.InteropServices;

Console.WriteLine("Weclome!\n");

do
{
    Console.WriteLine("Entered MAIN loop.");

    bool parseResult;

    do
    {
        Console.WriteLine("Please enter a valid number: ");
        string userInput = Console.ReadLine();

        // Find out if the user's string is actually an integer. If parse is successful, the method returns a TRUE bool. You also have access to the parsed number with the 'out' parameter.
        parseResult = int.TryParse(userInput, out int userNum);

    } while (parseResult == false);


    do
    {
        Console.WriteLine("Another number please: ");
        string userInput = Console.ReadLine();      
        // Find out if the user's string is actually an integer. If parse is successful, the method returns a TRUE bool. You also have access to the parsed number with the 'out' parameter.
        parseResult = int.TryParse(userInput, out int userNum);

    } while (parseResult == false);


    do
    {
        Console.WriteLine("OKAY one more number: ");
        string userInput = Console.ReadLine();

        // Find out if the user's string is actually an integer. If parse is successful, the method returns a TRUE bool. You also have access to the parsed number with the 'out' parameter.
        parseResult = int.TryParse(userInput, out int userNum);

    } while (parseResult == false);


    Console.WriteLine("End of MAIN loop. Enter 'y' to restart: ");
} while (Console.ReadLine() == "y");

Console.WriteLine("Exiting app...");