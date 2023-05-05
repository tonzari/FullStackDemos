# TypeScript Key Points

It's helpful to know some JavaScript before you start TypeScript. 

**Why?**

TypeScript is a 'superset' of JavaScript. That means TypeScript includes EVERYTHING from JavaScript, but expands upon it to provide extra features.

**What extra features?**

- Static types / Type Safety
- Tooling (IDE debugging, color coding, analysis, detect unreachable code, etc.)
- Interfaces, Modules, and other organizational features


# TypeScript vs JS vs C#

## Variables
Take note of how variables are declared in each language. C# requires you to declare the type, while Javascript omits the type. Typescript gives you the option of declaring a type.

### C# Variables

```csharp
int myInt = 42;
double myDouble = 3.14;
bool myBool = true;
string myString = "Hello, World!";
List<int> myIntList = new List<int> {1, 2, 3, 4, 5};
```
### JavaScript Variables

```javascript
let myInt = 42;
let myDouble = 3.14;
let myBool = true;
let myString = "Hello, World!";
let myIntList = [1, 2, 3, 4, 5];

console.log(myInt, myDouble, myBool, myString, myIntList);
```

### Typescript Variables
```typescript
let myInt: number = 42;
let myDouble: number = 3.14;
let myBool: boolean = true;
let myString: string = "Hello, World!";
let myIntList: number[] = [1, 2, 3, 4, 5];

console.log(myInt, myDouble, myBool, myString, myIntList);
```

## Functions

### C# Methods

```csharp
public int Add(int a, int b)
{
    return a + b;
}

public double Multiply(double a, double b)
{
    return a * b;
}

public string Greet(string name)
{
    return $"Hello, {name}!";
}
```
### JavaScript Functions

```javascript
function add(a, b) {
    return a + b;
}

function multiply(a, b) {
    return a * b;
}

function greet(name) {
    return `Hello, ${name}!`;
}

console.log(add(2, 3), multiply(4, 5), greet("World"));
```

### Typescript Functions
```typescript
function add(a: number, b: number): number {
    return a + b;
}

function multiply(a: number, b: number): number {
    return a * b;
}

function greet(name: string): string {
    return `Hello, ${name}!`;
}

console.log(add(2, 3), multiply(4, 5), greet("World"));
```

### Arrow Function Versions for JS and TS
### JavaScript
```javascript
const add = (a, b) => {
    return a + b;
};

const multiply = (a, b) => {
    return a * b;
};

const greet = (name) => {
    return `Hello, ${name}!`;
};
```
### Typescript

```typescript
const add = (a: number, b: number): number => {
    return a + b;
};

const multiply = (a: number, b: number): number => {
    return a * b;
};

const greet = (name: string): string => {
    return `Hello, ${name}!`;
};

console.log(add(2, 3), multiply(4, 5), greet("World"));
```

## Classes

### C#
```csharp
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}

```

### JavaScript
```javascript
class Person {
    constructor(firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    getFullName() {
        return `${this.firstName} ${this.lastName}`;
    }
}

const person = new Person("John", "Doe");
console.log(person.getFullName());
```

### TypeScript
```typescript
class Person {
    firstName: string;
    lastName: string;

    constructor(firstName: string, lastName: string) {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    getFullName(): string {
        return `${this.firstName} ${this.lastName}`;
    }
}

const person: Person = new Person("John", "Doe");
console.log(person.getFullName());
```

## Links

https://www.typescriptlang.org/play

The Why/What/When/Where/Who of TypeScript: https://www.youtube.com/watch?v=i43W0XSiuIE

https://learntypescript.dev/

https://www.typescriptlang.org/docs/handbook/typescript-in-5-minutes-oop.html