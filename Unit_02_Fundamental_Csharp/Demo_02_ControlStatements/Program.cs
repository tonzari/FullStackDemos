// Basic If statement demo

Console.WriteLine("Program begins...");

bool isComplete = false;

if (isComplete == true)
{
    Console.WriteLine("IF BLOCK ENTERED!");
}
else
{
    Console.WriteLine("ELSE BLOCK ENTERED!");
}

Console.WriteLine("Program ends.");

string petName = "Luke";
string petType = "Dog";

Console.Write("What type of pet do you have?: ");
string userPet = Console.ReadLine().Trim();

if (userPet.ToLower() == petType.ToLower())
{
    Console.WriteLine("Bow wowowowooo.");
    Console.WriteLine("you entered: " + userPet);

    Console.WriteLine("What is your dogs name?");
    string userPetName = Console.ReadLine();

    if (userPetName.ToLower() == petName.ToLower())
    {
        Console.WriteLine("That was my childhood's dog's name too!");
    }
}
else if (userPet.ToLower() == "cat")
{
    Console.WriteLine("Ok meow");
}
else if (userPet.ToLower() == "lizard")
{
    Console.WriteLine("slurp slurp");
}
else if (string.IsNullOrEmpty(userPet) == true && string.IsNullOrWhiteSpace(userPet) == true)
{
    Console.WriteLine("You didn't enter a pet!");
}
else
{
    Console.WriteLine("Oh ok, that must be a nice pet.");
}

/* 
 * 
 * Relational Operators
 * 
 * ==       equality
 * !=       inequality
 * >        greater than
 * <        less than
 * >=       greater than or equal to
 * <=       less than or equal to
 * 
 */

bool isDog = false;

if (isDog != true) // same as 'isDog == false'
{
    Console.WriteLine("not a dog");
}

int age = 35;
const int myMom = 65;

if (age > myMom)
{
    Console.WriteLine("older than my mom");
}

if(age <= myMom)
{
    Console.WriteLine("My mom's age or younger");
}

if (age < myMom)
{
    Console.WriteLine("Younger than my mom");
}

// Switch
switch (age)
{
    case < 21: Console.WriteLine("You are 20. Can't drink.");
        break;
    case myMom: Console.WriteLine("You are the same age as my mom!"); // a constant is necessary. you can't use a normal variable! 
        break;
    default:
        break;
}

// LOOP 

for (int i = 100; i > 0; i--)
{
    Console.WriteLine(i);
}

// i is 0, that's less than 5, so run the code... and check again
// i+ 1.. i is 1, that's less than 5, so run the code...
