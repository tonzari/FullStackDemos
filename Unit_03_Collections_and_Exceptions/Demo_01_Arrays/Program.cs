// Arrays 
string[] names = new string[6];

names[4] = "Jeff";
names[0] = "Grace";
names[1] = "Selena";
names[2] = "Patti";

// Access array element directly by position
Console.WriteLine(names[1]);
Console.WriteLine(names[2]);

// Loop through all the elements
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"{i}. {names[i]}");
}


int[] userIds = new int[] { 2, 3, 5, 8, 11 }; // You can create arrays of just about any type, and you can also initialize the values immediately in {} brackets



// Demo: Ask the user how many movies they want to add to a list, then prompt the user to add each title.

Console.WriteLine("\n\nHow many movie titles do you want to enter?");
int userNum = int.Parse(Console.ReadLine());

string[] titles = new string[userNum];

// Get the input for each element in the array
for (int i = 0; i < titles.Length; i++)
{
    Console.Write("Enter movie title: ");
    string title = Console.ReadLine();

    titles[i] = title;

    Console.WriteLine("\n");
}

// Print out the value for each element of the array
foreach (string title in titles)
{
    Console.WriteLine(title);
}

// What if you want the index number? Better to use a for loop...
for (int i = 0; i < titles.Length; i++)
{
    Console.WriteLine($"{i + 1}. {titles[i]}");
}

Console.WriteLine("\n");

for (int i = 0; i < titles.Length; i += 2)
{
    Console.WriteLine($"{i + 1}. {titles[i]}");
}


Console.WriteLine("\n\n\n");
// Use case for arrays!

string dessertApiResponse = "Baklava, Cannoli, Crema Catalana, Creme Brulee, Gulab Jamun, Churros, Eclairs, Flan, Fruit Tart, German Chocolate Cake, Green Tea Ice Cream, Kheer, Kulfi, Mochi, Panna Cotta, Pavlova, Pecan Pie, Profiteroles, Red Bean Paste, Tiramisu, Tres Leches, Ube Halaya, Waffles, Yema";
string[] desserts = dessertApiResponse.Split(", ");

for (int i = 0; i < desserts.Length; i++)
{
    //Console.WriteLine($"{i + 1}. + {desserts[i]}");
    if (desserts[i].StartsWith('G'))
    {
        Console.WriteLine($"{i + 1}. {desserts[i]}");
    }
}

Console.WriteLine("Array.Sort() example:");
Array.Sort(desserts);
int binarySearchResult = Array.BinarySearch(desserts, "Churros"); // The array must be properly sorted (ascending) before using Binary Search.
Console.WriteLine("Binary Search Result: " + binarySearchResult);

Array.Reverse(desserts);

foreach (var item in desserts)
{
    Console.WriteLine(item);
}