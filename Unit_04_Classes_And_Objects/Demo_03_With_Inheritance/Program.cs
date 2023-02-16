

using Demo_03_With_Inheritance;

Pig myPig = new Pig();
Pig myPig2 = new Pig();
Dog myDog = new Dog();
Dog myDog2 = new Dog();

// Any class that inherits Animal can be put in this list
List<Animal> animals = new List<Animal>()
{
    myPig, myPig2, myDog, myDog2
};

foreach (Animal animal in animals)
{
    animal.AnimalSound();
}