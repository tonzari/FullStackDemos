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

// cardinaleDirs = 123; // Uncaught TypeError: invalid assignment to const 'cardinaleDirs'
// cardinaleDirs = ["Norte", "Este"]; // Uncaught TypeError: invalid assignment to const 'cardinaleDirs'

console.log(cardinaleDirs[0]);

cardinaleDirs[0] = "Norte";
cardinaleDirs[1] = "Este";
cardinaleDirs[2] = "Sud";
cardinaleDirs[3] = "Oeste";

console.log(cardinaleDirs);

const looseyGooseyArray = [123, false, "Dogs", myBirthdate];

console.log(looseyGooseyArray);

// On the next episode of Grand Circus Class....
// Array methods
// pop, push, filter








// - - - - Notes / Links - - - - - - - - - - - - - - - - - - - - 
/*

1 - Without a strong understanding of JavaScript scope and 'hoisting',
    var may cause you many hard to track bugs.

    Want to learn more? Check out these resources:

    Mozilla docs: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Statements/var#var_hoisting
    Youtube Web Dev Simplified tutorial: https://www.youtube.com/watch?v=EvfRXyKa_GI

*/