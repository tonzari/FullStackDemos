console.log("hello from demo 03 app.js!")

/*

    Welcome to the variable demo!
    This is a multi-line comment!

*/

// Here is a single line comment.

/*

    Variables can be declared in 3 different ways:

    var
    let
    const

    JavasScript is a loosely typed language.
    That's different from C#, which is a strongly typed language. (ex: int myNum = 12;)

    So in JS, we don't do that. We don't define the datatype when creating a variable.

*/





// - - - - var - - - - - - - - - - - - - - - - - - - - - - - - -
// *1 Please do not use var unless you have a good reason to use it. (See notes at bottom of file)
var myVariable = "Here's some text in a string";
myVariable = 123;
myVariable = false;
myVariable = "See how we just changed the data type of this variable with no problem? JS is loosey goosey.";




// Instead we can use...

// - - - - let - - - - - - - - - - - - - - - - - - - - - - - - -

let myName = "Hector";
let myAge = 44;
let myHeight = 182.19;
let isFunny = false;

// isFunny = "definitely";
// console.log(isFunny);





// - - - - const - - - - - - - - - - - - - - - - - - - - - - - - -
// const values cannot change. However, there's an excepetion... (see array section below)

const myBirthYear = 1922;
const myBirthdate = new Date("1922-02-01");

// myBirthYear = 1987; // WRONG! Uncaught TypeError: invalid assignment to const 'myBirthYear'






// - - - - arrays - - - - - - - - - - - - - - - - - - - - - - - - -

const cardinaleDirs = ["NORTH","EAST","SOUTH","WEST"];

console.log(cardinaleDirs);


// NOTE: consts can't change! If you try to change the array object itself, you'll get an error.

// cardinaleDirs = 123; // Uncaught TypeError: invalid assignment to const 'cardinaleDirs'
// cardinaleDirs = ["Norte", "Este"]; // Uncaught TypeError: invalid assignment to const 'cardinaleDirs'

console.log(cardinaleDirs[0]);

cardinaleDirs[0] = "Norte";
cardinaleDirs[1] = "Este";
cardinaleDirs[2] = "Sud";
cardinaleDirs[3] = "Oeste";

console.log(cardinaleDirs);

const looseyGooseyArray = [123, false, "Dogs", myBirthdate]; // hover over the variable name. notice the datatypes!

console.log(looseyGooseyArray);

// On the next episode of Grand Circus Class....
// Array methods
// pop, push, filter, indexOf, isArray, etc.

const birdSpecies = ["Northern Cardinal", "American Robin", "Blue Jay"];

// Adding to an array in JS is a little different than C#
// Use the built-in method "push"
birdSpecies.push("House Sparrow");
birdSpecies.push("Song Sparrow");

// Remove from an array with the built-in method "pop"

// lets' add something worth removing...
birdSpecies.push("Pigeon");

console.log(birdSpecies);

// remove the last element
const popResult = birdSpecies.pop();
console.log("pop result: " + popResult);
//const removedBird = birdSpecies.pop(); // store the result of the removal

console.log(birdSpecies);

// array filter method, and string includes method
const onlySparrows = birdSpecies.filter(
    function(currentElement) {
        return currentElement.includes("Sparrow") === true;
    }
)

console.log(onlySparrows);

// If found: returns index,
// if not found: returns -1
console.log("Found at" + birdSpecies.indexOf("Blue Jay"));
console.log("Not found!" + birdSpecies.indexOf("Dog"));

birdSpecies.unshift("Canada Goose");

console.log(birdSpecies);

console.log("birdSpecies array index 20: " + birdSpecies[20]);



// - - - - data types - - - - - - - - - - - - - - - - - - - - - - - - -

// number
// string
// boolean
// null         -- unintentional absence of value
// undefined    -- variable exists, but a value has not yet been assigned

let myNull;
let myUndefined;

console.log("myNull: " + myNull);
console.log("myUndefined: " + myUndefined);

// explicitly set myNull to 'null'
myNull = null;

console.log("myNull: " + myNull);







// - - - - comparison - - - - - - - - - - - - - - - - - - - - - - - - -

// =    assign (not comparion)
// ==   comparison (loose equality, double equals)
// ===  comparison (strict equality, triple equals)
// !=   comparison (loose inequality)
// !==  comparison (strict inequality)

// NOTE: Use === for equality, and use !== for inequality unless you have a good reason to use == !=

const numAsString = "5";
const numAsNumber = 5;

console.log("Is the string '5' equal to the number 5 using double equals? ==")
if(numAsString == numAsNumber)
{
    console.log("Yes, they are equal!");
}

console.log("Is the string '5' equal to the number 5 using triple equals? ===")
if(numAsString === numAsNumber)
{
    console.log("Yes, they are equal!");
}
else
{
    console.log("No, they are not equal!");
}

if (myNull == myUndefined) {
    console.log("with ==, null and undefined are equal");
}

if (myNull === myUndefined) {
    console.log("with ===, null and undefined are equal");
}
else{
    console.log("with ===, null and undefined are NOT equal");
}

const a = .1;
const b = .2;
const c = .3;
const d = a + b;

console.log(c, d);
console.log(a + b == c);
console.log(a + b === c);
console.log(a + b == d);
console.log(a + b === d);


// - - - - Function - - - - - - - - - - - - - - - - - - - - - - - 

// declare a function
function myFunction()
{
    // do something!
    console.log("Hello from myFunction()!");
}

// call the function
myFunction();

function myFunctionWithParameters(firstParam, secondParam)
{
    // do something
    return firstParam + ", " + secondParam;
}

const myFuncResult1 = myFunctionWithParameters("dog", "cat");
console.log(myFuncResult1);

const myFuncResult2 = myFunctionWithParameters(200, 404);
console.log(myFuncResult2);

const myFuncResult3 = myFunctionWithParameters(myBirthdate, birdSpecies);
console.log(myFuncResult3);


// - - Arrow function breakdown - - 

// named function
function myAddFunction(a, b) {
    return a + b;
}

console.log(myAddFunction(2,5));

// arrow function: no function keyword or name, used a variable to store function
let myAddResult = (a, b) => {
    return a + b;
}

console.log(myAddResult(2,5));

// arrow function: no function keyword or name, used a variable to store funtion, can omit { }
let myAddResultArrowFunction = (a, b) => a + b;

console.log(myAddResultArrowFunction(5,2));


// arrow function: no function keyword or name, used a variable to store funtion, can omit { }, can omit parans if there is just one parameter

let myAddFunctionStripped = a => a + a;

console.log(myAddFunctionStripped(7));








// - - - - Loops - - - - - - - - - - - - - - - - - - - - 

// see birdSpecies array initialization above

// For Loop
for (let i = 0; i < birdSpecies.length; i++) {
    const bird = birdSpecies[i];

    console.log(`${i + 1}. ${bird}`);
}

// For Of Loop
for (const bird of birdSpecies) {
    console.log(bird);
}

// Array method. forEach Loop

birdSpecies.forEach( b => console.log("forEach: " + b.toUpperCase()) );

birdSpecies.forEach( currentBird => {
    
    if(currentBird.includes("Sparrow"))
    {
        console.log(currentBird);
    }

});


// while and do while loops exist, they have the same syntax as C#






// - - - - Notes / Links - - - - - - - - - - - - - - - - - - - - 
/*

1 - Without a strong understanding of JavaScript scope and 'hoisting',
    var may cause you many hard to track bugs.

    Want to learn more? Check out these resources:

    Mozilla docs: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Statements/var#var_hoisting
    Youtube Web Dev Simplified tutorial: https://www.youtube.com/watch?v=EvfRXyKa_GI

*/