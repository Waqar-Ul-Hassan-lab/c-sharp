using System;

namespace LoopsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================================");

            // -------------------------------------------------------------
            // 1. While Loop: Input Validation (repeats until valid input)
            // -------------------------------------------------------------
            string name = "";

            while (name == "")
            {
                Console.Write("Enter your name : ");
                name = Console.ReadLine() ?? "";
            }
            Console.WriteLine("Hello, Mr. " + name);

            Console.WriteLine("=================================================");

            // -------------------------------------------------------------
            // 2. For Loops: Counting Up and Down
            // -------------------------------------------------------------
            // Forward counting loop (0 to 4)
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Counting Up : " + i);
            }

            // Reverse counting loop (10 down to 1)
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Reverse Counting : " + i);
            }

            Console.WriteLine("=================================================");

            // -------------------------------------------------------------
            // 3. Nested For Loops: Printing a 2D Grid Pattern
            // -------------------------------------------------------------
            Console.Write("Enter the number of Rows : ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of Columns : ");
            int columns = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < rows; j++)
            {
                for (int k = 0; k < columns; k++)
                {
                    Console.Write("@ ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("=================================================");
        }
    }
}