using System;

namespace MultipleConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================");

            // -------------------------------------------------------------
            // 1. Exception Handling: Basic try-catch-finally
            // -------------------------------------------------------------
            try
            {
                Console.Write("Enter an integer : ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You entered: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
            finally
            {
                // 'finally' block always executes regardless of exceptions
                Console.WriteLine("Execution completed.");
            }

            Console.WriteLine("===========================================");

            // -------------------------------------------------------------
            // 2. Handling Multiple Specific Exceptions
            // -------------------------------------------------------------
            try
            {
                Console.Write("Enter a number to divide 100 by : ");
                int divisor = Convert.ToInt32(Console.ReadLine());
                int result = 100 / divisor;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }

            Console.WriteLine("===========================================");

            // -------------------------------------------------------------
            // 3. Ternary Operator (condition ? valIfTrue : valIfFalse)
            // -------------------------------------------------------------
            try
            {
                Console.Write("Enter the temperature in Celsius : ");
                double temperature = Convert.ToDouble(Console.ReadLine());

                string weatherCondition = (temperature > 30) ? "Warm Outside" : "Cold Outside";
                Console.WriteLine("Weather Condition : " + weatherCondition);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred.");
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }

            Console.WriteLine("===========================================");

            // -------------------------------------------------------------
            // 4. Multi-Dimensional 2D Arrays (string[,])
            // -------------------------------------------------------------
            string[] fruits = { "Apple", "Banana", "Cherry", "Date" };
            string[] vegetables = { "Carrot", "Broccoli", "Spinach", "Potato" };
            string[] grains = { "Rice", "Wheat", "Oats", "Barley" };

            string[,] foodList =
            {
                { "Apple", "Banana", "Cherry", "Date" },
                { "Carrot", "Broccoli", "Spinach", "Potato" },
                { "Rice", "Wheat", "Oats", "Barley" }
            };

            // GetLength(0) returns row count (dimension 0)
            // GetLength(1) returns column count (dimension 1)
            Console.WriteLine("Food List (Table Format):");
            for (int i = 0; i < foodList.GetLength(0); i++)
            {
                for (int j = 0; j < foodList.GetLength(1); j++)
                {
                    Console.Write(foodList[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("===========================================");

            // -------------------------------------------------------------
            // 5. Accessing Specific 2D Array Element (0-indexed [row, col])
            // -------------------------------------------------------------
            Console.WriteLine("Item at row 1, col 3 (Potato): " + foodList[1, 3]);

            Console.WriteLine("===========================================");

            // -------------------------------------------------------------
            // 6. Iterating Through All Elements in 2D Array with foreach
            // -------------------------------------------------------------
            Console.WriteLine("All Food Items:");
            foreach (string item in foodList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===========================================");
        }
    }
}