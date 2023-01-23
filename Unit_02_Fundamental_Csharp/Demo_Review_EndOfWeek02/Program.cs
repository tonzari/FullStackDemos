using MethodExamples;

// data types and variables

//numbers
double start = 3.456;
decimal strong = 3.2m;
decimal money = 7.1m;
int length = 74;
float boat = 22.5f;
long wow = long.MinValue;
ulong hello = ulong.MaxValue;

bool isTrue = false;

string color = "Howdy";
char myLetter = 'a';

const double PI = 3.14;
const string DIRECTION = "NORTH";

var someVariable = "string";
var someOtherVariable = 123;
var anotherVariable = 'c';




// loops: for loop, do while, while, foreach

for (int i = 0; i <= 10; i++)
{
    Console.Write($"{i}");
}

bool doAgain = false;
do
{
    Console.WriteLine("I didn't copy this");
} while (doAgain);


while (false)
{
    Console.WriteLine("loop");
}

List<string> names = new List<string>()
{
    "Bella",
    "Douglas",
    "Priyanka",
    "Opi"
};

foreach (string name in names)
{
    Console.WriteLine($"Hello, {name}!");
}


// Control statements: if, if/else, switch

int num1 = 8;

if (num1 == 9)
{
    // do the thing
}

if (true)
{
    // do this if true
}
else
{
    // otherwise do this
}

// do one of the following 
if (true)
{
    // do this 
}
else if (true)
{
    // OR this
}
else
{
    // OR finally just do this
}

int caseSwitch = 1;
switch (caseSwitch)
{
    case 1:
        int age = 2;
        Console.WriteLine(age);
        break;
    default:
        Console.WriteLine("Default");
        break;
}

// Methods

MethodReview.MakeGreen();

string phoneNum = MethodReview.GetPhoneNumber();
Console.WriteLine(phoneNum);

// overloaded versions of GetPhoneNumber()
string personsPhoneNum = MethodReview.GetPhoneNumber("name1", "name2"); // this one takes two strings as arguments
string otherPersonsNum = MethodReview.GetPhoneNumber(7);                // this one takes one int as an argument




// hint on dice roller
/*

int dice1 = DiceRoller.RollDie(); // will return a value between 1 and 6
int dice2 = DiceRoller.RollDie(); // run it again and store a second time

 */
