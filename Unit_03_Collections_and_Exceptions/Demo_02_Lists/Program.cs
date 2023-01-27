// What's the difference between arrays and lists?
// --- The size of an ARRAY must be determined upon initialization. For example, you create an array of strings, and declare it a size of 6, and it will ALWAYS have 6 elements.
// --- With LISTS, you never have to determine the size of it before hand. You add and remove elements as you go. It is dynamic. 


List<string> animals = new List<string>();

/*
 * 
 * LIST METHODS
 * 
 */

// ADD

animals.Add("Platypus");
animals.Add("Octopus");
animals.Add("Narwhal");

Console.WriteLine("Added 3 animals... print all:");
foreach (string animal in animals)
{
    Console.WriteLine(animal);
}

// REMOVE

Console.WriteLine("\n\n");

animals.Remove("Narwhal");

Console.WriteLine("Removed one animal... print all:");
foreach (string animal in animals)
{
    Console.WriteLine(animal);
}

// You can change the content of an element
// It is the same process as with arrays
Console.WriteLine("The first element at position 0 is: " + animals[0]);
animals[0] = "Leafy sea dragon"; // You can modify the element directly by index.

Console.WriteLine("NOW, the first element at position 0 is: " + animals[0]);

Console.WriteLine("Animals.Count : " + animals.Count); // Counts total amount of elements (highest index will be .Count - 1 )

// Trying to access an element out of bounds will cause an error. Check before accessing that element...
if (2 < animals.Count - 1)
{
    animals[2] = "Dog";
}

// CONTAINS

bool containsResult = animals.Contains("Octopus");
Console.WriteLine("ContainsResult for Octopus: " + containsResult);

bool containsResult2 = animals.Contains("Dog");
Console.WriteLine("ContainsResult for Dog: " + containsResult2);

// INSERT

Console.WriteLine("\n\n");

animals.Insert(0, "Glass frog");
Console.WriteLine("Inserted new at 0... print all:");
foreach (string animal in animals)
{
    Console.WriteLine(animal);
}

Console.WriteLine("\n\n");

animals.Insert(0, "Flamingo");
animals.Insert(0, "Aye-aye");
Console.WriteLine("Inserted more each at 0... print all:");
foreach (string animal in animals)
{
    Console.WriteLine(animal);
}

// animals.Insert(10, "Dog"); // You must insert into an already existing index!

//animals[5] = "Dog";
animals.Insert(5, "Dog"); // You CAN insert at the next element position above upper boundary

// ToList() Demo
string animalsAsString = "Platypus, Octopus, Narwhal, Leafy sea dragon, Kakapo parrot, Glass frog, Flamingo, Deep sea anglerfish, Aye-aye, Pangolin, Sea Pig, Sunfish, Giant Isopod, Sunda Colugo";
//string[] arrayOfAnimals = animalsAsString.Split(", ");
//List<string> largeAnimalList = arrayOfAnimals.ToList(); // We've convereted an array to a list very easily.
List<string> largeAnimalList = animalsAsString.Split(", ").ToList(); // One liner option. Same as the two lines of code above.