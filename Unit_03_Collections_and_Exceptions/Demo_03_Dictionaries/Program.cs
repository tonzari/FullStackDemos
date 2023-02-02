
/*
 * 
 * Dictionary Basics: Dictionary<key, value>
 * 
 */

// left side of = sign, we are declaring a dictionary variable

Dictionary<string, string> englishToSpanish = new Dictionary<string, string>();

englishToSpanish["hello"] = "hola";                     // You can get or set a key and its value directly
englishToSpanish.Add("goodbye", "adios");               // Or your can use the Add() method to set a key and its value
englishToSpanish.Add("tomorrow", "mañana");             // You may NOT have duplicate keys. You can however duplicate the values...
englishToSpanish.Add("morning", "mañana");              // ... No problem duplicating values. 
//englishToSpanish.Add("tomorrow", "cant do this");     // Nope! This will cause an error. 'tomorrow' is already a key

Console.WriteLine($"How do you say 'hello' in Spanish? {englishToSpanish["hello"]}");
Console.WriteLine($"How do you say 'goodbye' in Spanish? {englishToSpanish["goodbye"]}");

// What happens if you try to pass a key that doesn't exist in the dictionary?
//Console.WriteLine(englishToSpanish["dog"]);             // Throws an exception!!

// How can we avoid throwing an exception?

if (englishToSpanish.ContainsKey("dog"))
{
    // do something
}
else
{
    Console.WriteLine("Sorry, didn't find dog.");
}


/*
 * 
 * Let's find out if the dictionary contains a certain KEY, and if so, let's get the VALUE
 * If the key isn't found, alert the user
 * 
 */

Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
Console.WriteLine("Search the English to Spanish Translation dictionary: ");

string searchTerm = Console.ReadLine();

if (englishToSpanish.ContainsKey(searchTerm))
{
    Console.WriteLine($"\n{searchTerm}: {englishToSpanish[searchTerm]}");
}
else
{
    Console.WriteLine($"Sorry, {searchTerm} wasn't found.");
}


// To be continued
// - a dictionary or int and list

Dictionary<int, List<string>> employeeDatabase = new();

List<string> skillsExample1 = new();
skillsExample1.Add("HTML");
skillsExample1.Add("CSS");
skillsExample1.Add("Javascript");

List<string> skillsExample2 = new();
skillsExample2.Add("SQL");
skillsExample2.Add("NoSQL");
skillsExample2.Add("MongoDB");


employeeDatabase.Add(44, skillsExample1);
employeeDatabase.Add(1, skillsExample2);

// Loops through each item in the Dictionary: an employee who has skills
foreach (var employee in employeeDatabase)
{
    // Print out ID number
    Console.WriteLine("Employee ID: " + employee.Key); 

    // Print out their skills
    foreach (string skill in employee.Value)
    {
        Console.WriteLine(skill);
    }
}



// Asma's question: Can you make a dictionary of type <string, decimal>? Yes!

Dictionary<string, decimal> keyValuePairs = new Dictionary<string, decimal>();
keyValuePairs.Add("Chocolate", 9.99m);
keyValuePairs.Add("Apple", 0.25m);
keyValuePairs.Add("Guava", 2.99m);

decimal total = keyValuePairs["Apple"] + keyValuePairs["Guava"];

Console.WriteLine(total); 

