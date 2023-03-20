using System;

namespace Strings.Price_Jacob
    
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ask user to input a character.
Declare and initialize the character inputted to the correct variable type, named myChar.
Use Console.ReadKey().KeyChar to get the character the user inputted.
Declare and initialize a boolean named isLetter, using the Char.IsLetter() method from the System.Char namespace to assign it.
Print out, "\n <myChar> is a letter: <isLetter>". <myChar> and <isLetter> should be actual variable values.
Use the special character for new line, at the beginning of the string, to start on the next line after reading a char. 


Ask the user to input a string of words.
Assign the inputted string to a variable.
Then ask the user to input a single word to search for.
Assign the inputted word to another variable.
Using the Contains() method from the String class, see if the string of words contains the word to search for and assign the results to a boolean variable.
Print out, "<string2> exists in <string1>, <boolean>". 
Where <string2> is the word to search for, <string1> is the string of words, and <boolean> is the result from the Contains method.
            */
            Console.WriteLine("PUSH A KEY  BICCHHHHH");
            char myChar = Console.ReadKey().KeyChar;
            bool isLetter = Char.IsLetter(myChar);
            Console.WriteLine("\n" + myChar + " is  a letter: " + isLetter);
            Console.WriteLine("\n Now type up some random words");
            string myText = Console.ReadLine();
            Console.WriteLine("\n Now a word so we can see if you already typed it");
            string myWord = Console.ReadLine();
            bool mybool2 = myText.Contains(myWord);
            Console.WriteLine("\n" + myWord + " is inside of your previous list: " + mybool2);
           

        }
    }
}
