//Conditionals
//allow us to create different paths within our code that we can take and prefrom different actions from

// If/Else-If/Else Statement
//Ask a question, perfrom an action if true, and preform a different action if false
// We will create boolean statements to rep our conditions, and then write some code that runs if any of those that are true

// if(condition){
//  code we want to run if true
//  Else if(another condition)
// }
// else {
// code we want to run if false
// }


var isSunny = true;
var isRaining = false;
var isCold = false;
var temp = 75;

if (isSunny && temp > 65)
{
    Console.WriteLine("It is sunny outside!");
}
else if (isSunny && temp >= 65)
{
    Console.WriteLine("Its a great day");
}
else
{
    Console.WriteLine("It is not sunny outside");
}

// How do we expand this to include more conditions
// Else if block allows us as a user to check for a addition condition in the event the first one is false

// what if we dont want to do anything else block?
// Else if and else blocks are optional

//If/else statments will only ever execute one condition. Once a condition is true, we run that code and skip to the end

//Switch Case statements
// We can use Switch/Case with many other values instead of just booleans
// You provide a value to switch on, and the code falls into a case where the value matches
// this means a switch case is just a bunch of equality checks
// Int, bool, enums, floats, strings, etc...
var errorCode = 404;
switch (errorCode)
{
    case 404: // can run two cases that are in the same catigory
    case 205:
        Console.WriteLine("Page not found.");
        break;
    case 203:
        Console.WriteLine("Inncorrect value,");
        break ;
    default:
        Console.WriteLine("Unknow Error Occured");
        break; 
}

// break --> ends the switch case
//goto case x --> jumps over to another case
// goto default --> jumps to default
// we can put labels next to each other without code inbetween if we want them to preform the same action

// Ternary Statements
// Ternary is in three parts
// 1. Question
// 2. Value if true
// 3. value if false 
// one of the main uses for ternary statements is shorthand for assigning values of some kind
var moodRating = 0;
var isHappy = false;
var isGlad = true;
if(isHappy)
{
    moodRating = 100;
}
else
{
    moodRating = -100;
}

// This is the same as the above lines of code
moodRating = isHappy ? 100 : -100; // ? --> is a if statement for values : means if not it replaces it with the next value
// slightly limited that the things after the ? and : must be values and only values

// Increment/Compound Operators 
// Shorthand for operations/actions

moodRating = moodRating + 1; //increases the value of mood rating by 1
moodRating += 1; //slighty different from =+) but for now just use +=
// Generalized: variable += x --> increases value by x 
//Both of these are the same
// Shorthand for increasing a varibale by 1
moodRating++; // -- Decreases a value by 1

moodRating *= 100; // WOuld * moodRating by 100 and store it in moodRatings value








