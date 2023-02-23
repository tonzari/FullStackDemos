
using Demo_06_Abstract_Demo;

//Animal myGeneralAnimal = new Animal(); // Cannot create an instance of an abstract class
Dog dog = new Dog();
Pig pig = new Pig();

// myGeneralAnimal.AnimalSound();

List<Animal> animals= new List<Animal>()
{
    dog,
    pig
};

foreach (Animal animal in animals)
{
    animal.AnimalSound();
}
