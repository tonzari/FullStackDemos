// File IO
// Our goal: Create a text file that we can write to.
//           We also want to read the text file back into our app.
// docs: https://learn.microsoft.com/en-us/dotnet/api/system.io.file?view=net-6.0
// How to check OS during runtime: https://mariusschulz.com/blog/detecting-the-operating-system-in-net-core

using System.Runtime.InteropServices;

string macPath = @"/Users/YourUserName/Desktop/MyTest.text";
string windowsPath = @"c:\Users\dude_dude\Desktop\MyTest.txt";
string path = string.Empty;

// Detect the Operating system

if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
{
    Console.WriteLine("Windows!");
    path = windowsPath;
}

if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
{
    Console.WriteLine("Mac!");
    path = macPath;
}

if (!File.Exists(path))
{
    // Create a file to write to.
    using (StreamWriter sw = File.CreateText(path))
    {
        sw.WriteLine("Hello");
        sw.WriteLine("And");
        sw.WriteLine("Welcome");
        sw.WriteLine(12345);
    }
}

// Open the file to read from.
using (StreamReader sr = File.OpenText(path))
{
    string s;
    while ((s = sr.ReadLine()) != null)
    {
        Console.WriteLine(s);
    }
}