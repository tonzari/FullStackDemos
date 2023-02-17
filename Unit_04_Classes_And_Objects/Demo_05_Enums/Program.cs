
using Demo_05_Enums;

Console.WriteLine(Days.Monday);

Person person = new Person();
person.FirstName = "Banana";

int currentHourOfTheDay = 14;

if (currentHourOfTheDay > 20)
{
    person.State = CurrentState.Sleeping;
}
else if (currentHourOfTheDay > 9)
{
    person.State = CurrentState.Working;
}

Console.WriteLine(person.FirstName + " is " + person.State);

switch (person.State)
{
    case CurrentState.Sleeping:
        // do this

        break;
    case CurrentState.Working:
        // do that

        break;
    case CurrentState.Eating:
        // do something else

        break;
    default:
        break;
}

// Referencing an enum from a class
Console.WriteLine(Enums.MyEnumInsideClass.FirstConstant);