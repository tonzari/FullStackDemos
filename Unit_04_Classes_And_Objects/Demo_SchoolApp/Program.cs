

using Demo_SchoolApp;

Console.WriteLine("Welcome to the School Online System! Please login in to continue.");

do
{
    Console.Write("Enter your email address: ");
    string userEmail = Console.ReadLine();

    Console.Write("Enter your password: ");
    string userPassword = Console.ReadLine();

    if (false)
    {
        // log the user in
        // the whole app functions here.
    }
    else
    {
        Console.WriteLine("Sorry, we couldn't log you in.");
    }

    Console.WriteLine("Would you like to restart the App? [y]");

} while (Console.ReadLine() == "y");

// DUMMY DATA

Student s1 = new Student();
s1.CurrentStatus = RegistrationStatus.Accepted;

