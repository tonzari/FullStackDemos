using System.Globalization;

string myString = "antonio"; // lower case string is an alias for the uppercase String class. use lowercase for consistency (if you want!)
//String name = "puppy";


myString = "Jax";         // a whole NEW string was created, and the variable now just points to a different location in memory
myString = "Brianna";     // the previous strings are taking up space in memory. you won't have to worry about this much for now.
string lorem = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
myString = "Pancakes";

/*int stringLength = myName.Length;

Console.WriteLine(stringLength);*/

char[] myCharArray = { 'B', 'r', 'i', 'a', 'n', 'n', 'a' };
string[] myStringArray = { "Jim", "Becca", "Stefania", "Noor", "Enrique" };

List<string> foods = new List<string>()
{
 "Sushi",
 "Pizza",
 "Tacos",
 "Curry",
 "Pho",
 "Falafel",
 "Paella",
 "Pad Thai",
 "Biryani",
 "Jerk Chicken"
};

// A string can also be treated as an array of chars! aka char[]
for (int i = 0; i < myString.Length; i++)
{
    Console.Write(myString[i]);
    System.Threading.Thread.Sleep(25);
}

Console.WriteLine("");

/*
 * 
 * 
 * String Methods
 * 
 */

// Concat
string concatExample = string.Concat("first string", myString);
Console.WriteLine(concatExample);

// Join
string joinExample = string.Join(", ", foods); // you can pass in a list or an array. the first parameter is the 'separator'
Console.WriteLine(joinExample);

// Compare and Equals

myString = "CAT";

int compareResult = string.Compare(myString, "cat", true); // ignores case (if set to true)
Console.WriteLine("Compare result: " + compareResult);

myString = "dog";

bool equalsResult = myString.Equals("DOG");
Console.WriteLine("Equal result: " + equalsResult);

// IndexOf
int indexOfDummy = lorem.IndexOf("dummy");
Console.WriteLine("Position: " + indexOfDummy);

int notFound = lorem.IndexOf("cxrcxr");
Console.WriteLine("Position: " + notFound);

// LastIndexOf
int lastIndexOfDummy = lorem.LastIndexOf("dummy");
Console.WriteLine("Position: " + lastIndexOfDummy);

// EndsWith
bool endsWithResult = myString.EndsWith("og");
Console.WriteLine("EndsWith result: " + endsWithResult);

CultureInfo cultureInfo = CultureInfo.CurrentCulture; // a cultureinfo is needed when making use of 'ignore case' in StartsWith() and we'll use it again for ToTitleCase()

bool startsWithResult = myString.StartsWith("D", true, cultureInfo);
Console.WriteLine("StartsWith result: " + startsWithResult);

// Replace
string replaceResult = myString.Replace('d', 'b');
Console.WriteLine(replaceResult);

string exampleSentence = "FYI, Sometimes it rains in April";
string replaceWordresult = exampleSentence.Replace("rains", "snows");
Console.WriteLine(replaceWordresult);

// Split
string[] splitResult = exampleSentence.Split(' ');
for (int i = 0; i < splitResult.Length; i++)
{
    Console.WriteLine(splitResult[i]);
}

// Substring
string substringResult = lorem.Substring(indexOfDummy);
Console.WriteLine(substringResult);

// ToUpper / ToLower
string toLowerResult = exampleSentence.ToLower();
Console.WriteLine(toLowerResult);

string toUpperResult = exampleSentence.ToUpper();
Console.WriteLine(toUpperResult);

string titleCaseResult = cultureInfo.TextInfo.ToTitleCase(exampleSentence); // Converts a string to Title Case - except for words that are ALL UPPERCASE (which are considered acronyms).
Console.WriteLine(titleCaseResult);

// Trim
string trimExample = "   Hello, my good friend   ";
Console.WriteLine(trimExample + "!");
string trimResult = trimExample.Trim();
Console.WriteLine(trimResult + "!");

/*
 * 
 * StringBuilder
 * 
 */
