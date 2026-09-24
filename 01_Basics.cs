using System; // Imports the System namespace containing fundamental classes like Console

class Program
{
    // Main() is the entry point of every C# application.
    // 'static': can run without instantiating the class.
    // 'void': returns no value.
    // 'string[] args': command-line arguments passed to the program.
    static void Main(string[] args)
    {
        // Console.WriteLine prints text to the terminal followed by a newline
        Console.WriteLine("Hello world, this is my first code");
        Console.WriteLine("John Player");

        // Console.ReadKey pauses execution until the user presses a key
        Console.ReadKey();
    }
}