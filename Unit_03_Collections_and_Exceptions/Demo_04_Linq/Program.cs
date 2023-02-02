// LINQ Demo (Language Integrated Query)

using Demo_04_Linq;

List<string> menu = MockDatabase.GetAllMenuItems();

// Let's say we wanted a new list based on the menu above. 
// This new list will contain ONLY menu items that contain the word: "coney"
// How would we do that?


// - - - - - - - - - - - - - -  With the tools we currently have learned - - - - - - - - - - - - - - - - - -

// 1. Create a new list for just the coneys

List<string> coneyList = new List<string>();

// 2. Loop through full menu and find items that contain the word "coney"

foreach (string item in menu)
{
	if (item.ToLower().Contains("coney"))
	{
        // 3. Add the item to the new list
        coneyList.Add(item);
	}
}

// - - - - - - - - - - - - - -  With LINQ: Lambda - - - - - - - - - - - - - - - - - -

var coneyListFromLambda = menu.Where(item => item.ToLower().Contains("coney"));
//				   in the menu, give me back ALL the items WHERE an item happens to be an item that contains the word "coney"



// - - - - - - - - - - - - - -  With LINQ: query expressions - - - - - - - - - - - - - - - - - -

var coneyListFromQuery = from item in menu
						 where item.ToLower().Contains("coney")
						 select item;


// Print the results!

Console.WriteLine("Results from our foreach loop: ");
foreach (var item in coneyList)
{
	Console.WriteLine(item);
}

Console.WriteLine("\nResults from our lambda: ");
foreach (var item in coneyListFromLambda)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nResults from our query: ");
foreach (var item in coneyListFromQuery)
{
    Console.WriteLine(item);
}
