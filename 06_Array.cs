using System;

namespace ArrayWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------------------------------
            // 1. Array Declarations and Direct Initialization
            // -------------------------------------------------------------
            // Traditional array initialization syntax
            string[] cars = { "Corvette", "BMW", "Toyota" };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);

            // Modern C# collection expression syntax: [...]
            string[] pakistaniCars = ["Honda", "Toyota", "Suzuki"];
            Console.WriteLine(pakistaniCars[0]);
            Console.WriteLine(pakistaniCars[1]);
            Console.WriteLine(pakistaniCars[2]);

            // -------------------------------------------------------------
            // 2. Fixed-Size Array Populated with a For Loop
            // -------------------------------------------------------------
            Console.WriteLine("\n--- Using the For Loop ---");

            string[] names = new string[3];

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter name #{i + 1} : ");
                names[i] = Console.ReadLine() ?? "";
            }

            Console.WriteLine("\nEntered Names:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1} : {names[i]}");
            }

            // -------------------------------------------------------------
            // 3. Iterating Over Arrays with a ForEach Loop
            // -------------------------------------------------------------
            Console.WriteLine("\n--- Using the ForEach Loop ---");

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}