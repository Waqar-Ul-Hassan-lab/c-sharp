using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world, this is my first code");
        Console.WriteLine("John Player");
        Console.ReadKey();
    }
}



/*

----------------------------------------------------------------------

Comment for the code above:

using System; // Imports the System namespace, which contains common classes like Console.

class Program // Creates a class named Program.
{
     Main() is the starting point of the program.
     static means we can run Main() without creating an object of the Program class.
     void means Main() does not return any value.
     string means the data will be text.
     [] means it is an array, so it can store multiple values.
     args is the variable name, short for "arguments".
    
     string[] args means:
     "An array of text values that can be provided to the program
     when the program is started from the command line."
    
     Example:
     If we run the program like this:
     MyProgram.exe John 25 Lahore
    
     Then:
     args[0] = "John"
     args[1] = "25"
     args[2] = "Lahore"
    
     All values are stored as strings, so "25" is also text.
    
     In this program, we are not using args, so it does not affect our code.
    static void Main(string[] args)
    {
        Console is used to work with the console/terminal.
        WriteLine() prints the given text on the screen and moves to the next line.
        Console.WriteLine("Hello world, this is my first code");

        Prints "John Player" on the console.
        Console.WriteLine("John Player");

        Waits for the user to press any key before the program closes.
        Console.ReadKey();
    }
}

----------------------------------------------------------------------

*/