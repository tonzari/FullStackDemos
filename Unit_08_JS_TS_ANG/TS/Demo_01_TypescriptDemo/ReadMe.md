# Typescript Introduction

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