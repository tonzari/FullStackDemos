using Demo_02_Static_Demo;

Pen pen1 = new Pen("black");

Console.WriteLine($"Pen ink level: {pen1.InkLevel * 100}%"); // public GET of ink level OK

pen1.InkLevel = 2f; // programmer attempts to set to 2... but fails! the SETTER limits to 1.0f

Console.WriteLine($"Pen ink level: {pen1.InkLevel * 100}%");

pen1.InkLevel = -1.0f;

Console.WriteLine($"Pen ink level: {pen1.InkLevel * 100}%");

Pen pen2 = new Pen("red");
Pen pen3 = new Pen("blue");
Pen pen4 = new Pen("magenta");


pen1.InkLevel = 100;

while (pen1.InkLevel > 0)
{
    pen1.Write();

    Console.ReadKey();
}

while (pen2.InkLevel > 0)
{
    pen2.Write();

    Console.ReadKey();
}


foreach (Pen pen in Pen.AllPens)
{
    Console.WriteLine($"{pen.InkColor}, {pen.InkLevel * 100}% ");
}

// What if we want do something to ALL pens?
// Is there a way that we can call a method for EVERY pen instance?

// YES! Static methods

Pen.RefillPens();

