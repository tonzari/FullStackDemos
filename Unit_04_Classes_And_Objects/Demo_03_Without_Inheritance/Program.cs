

using Demo_03_Without_Inheritance;

Pig myPig = new Pig();
Pig myPig2 = new Pig();
Dog myDog = new Dog();
Dog myDog2 = new Dog();

List<Pig> myPigList = new List<Pig>()
{
    myPig,
    myPig2
};

List<Dog> myDogList = new List<Dog>()
{
    myDog,
    myDog2
};


foreach (Pig pig in myPigList)
{
    pig.AnimalSound();
}

foreach (Dog dog in myDogList)
{
    dog.AnimalSound();
}

// Let's try to put all the animals in one list... the only common ground they have is the 'object' class...
List<object> myGeneralList = new List<object>()
{
    myPig,
    myPig2,
    myDog,
    myDog2
};

foreach (object animal in myGeneralList)
{
    if (animal is Dog dog)
    {
        dog.AnimalSound();
    }

    if (animal is Pig pig)
    {
        pig.AnimalSound();
    }
}
