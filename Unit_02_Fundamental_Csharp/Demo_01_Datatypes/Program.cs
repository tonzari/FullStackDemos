/*
 * This is a multiline comment
 * 
 * 
 * You can make it as many lines long as you'd like!
 */

// This is a single line comment. Two forward slashes. 

/*
Naming Convention examples:
 PascalCase
 camelCase
 snake_case
 kebab-case
 see more: https://github.com/ktaranov/naming-convention in the C# section

 Please try to use the naming conventions suggested by Microsoft for the boot camp.
*/

// VARIABLES
// Used to store date
// syntax: type variableName = value;
// some basic types: int, double, bool, decimal, float

string greeting = "Good evening";   // a string literal
int age = 0;                        // a whole number
double weight = 1.84;               // General purpose number with a decimal place.
decimal price = 1.84m;              // Very precise but costs more memory. Use for money!
bool isAlive = true;                // Can only be true or false;
float xPosition = 45.45f;           // Useful when performance is necessary, such as in game development.

double averageGradeIncorrect = (99 + 80 + 30 + 24) / 4;             // Evaulated as an integer, but because integers FIT INTO doubles, the error may go unnoticed
double averageGrade = (99.0 + 80.0 + 30.0 + 24.0) / 4.0;            // If you want a double, be explicit and use a decimal point
decimal averageDecimal = (99.0m + 80.0m + 30.0m + 24.0m) / 4.0m;    // If you want a decimal, be explicit and use the m suffix 

Console.WriteLine(averageGradeIncorrect);
Console.WriteLine(averageGrade);
Console.WriteLine(averageDecimal);

// Null - lacking value

int? currentAge = null;         // int is non-nullable, but we can essentially say "the value for currentAge is no longer required" by making it nullable with the ? after the type declaration
double? currentWeight = null;   // double **
decimal? currentPrice = null;   // decimal **
string middleName = null;       // string is nullable but the compiler will warn you that this might cause a problem
string? maidenName = null;      // string is nullable and we can prevent the warning by expliciting marking the declaration with a nullable ?

// Strings

string firstName = "Dolly";
string lastName = "Parton";
Console.WriteLine(firstName + " " + lastName);                  // string concatenation
Console.WriteLine($"{firstName} Samantha {lastName}");          // string interpolation
string test = string.Format("{0} {1}", firstName, lastName);    // string.Format method
Console.WriteLine(test);


Console.WriteLine("123 Evergreen Terrace \n Springfield, XX");  // Escape characters
Console.WriteLine(@"C:\Program\Dhadhadha.txt");                 // Ignore escape characters using @. It's a verbatim string literal
Console.WriteLine("C:\\Program\\Dhadhadha.txt");                // How do you print an escape character without @? Type it again! \\     

//Console.Read();                                               // Pause the console. Continue on key press.


var averagedNum = (4 + 4) / 3;                                  // evaluates as an integer!! -- Quick cautionary note on using var! If you end up using var, guess what type the var is evaulating to and hover over 'var' to see the answer. If you're wrong, hold off on var until you are confident in the types you are working with.


/*
 * Get user input review
 */

Console.WriteLine("How old is your pet?");

string userInput = Console.ReadLine();

int userPetAge = int.Parse(userInput);

int yearsToAdd = 5;

Console.WriteLine($"That other pet is {yearsToAdd} older. It's {userPetAge + yearsToAdd} years old.");