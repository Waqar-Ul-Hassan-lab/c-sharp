using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------------------------------
            // 1. Method Overloading Demonstration
            // Methods can share the same name if they have different parameter lists.
            // (Uncomment the lines below to test user input)
            // -------------------------------------------------------------
            // Console.Write("Enter the Birthday Boy Name : ");
            // string birthdayBoyName = Console.ReadLine() ?? "";
            //
            // Console.Write("Enter the Birthday Boy Age : ");
            // int birthdayBoyAge = Convert.ToInt32(Console.ReadLine());
            //
            // Console.Write("Enter the Birthday Boy Status : ");
            // string birthdayBoyStatus = Console.ReadLine() ?? "";
            //
            // Console.WriteLine("===========================================");
            // BirthdayMethod(birthdayBoyName, birthdayBoyAge);
            //
            // Console.WriteLine("===========================================");
            // string output = BirthdayMethod(birthdayBoyName, birthdayBoyAge, birthdayBoyStatus);
            // Console.WriteLine(output);

            Console.WriteLine("===========================================");

            // -------------------------------------------------------------
            // 2. The 'params' Keyword
            // 'params' enables passing a variable number of arguments as an array.
            // -------------------------------------------------------------
            double output = ParamsMethod(3.12, 34.2, 34.2, 34.1, 534.2);
            Console.WriteLine("Total Price : " + output);

            double output2 = ParamsMethod(3.12, 34.2, 34.2);
            Console.WriteLine("Total Price : " + output2);
        }

        // Overload 1: Takes 2 parameters (void return)
        static void BirthdayMethod(string name, int age)
        {
            Console.WriteLine($"Happy Birthday : {name}, \nYou are {age} years old");
        }

        // Overload 2: Takes 3 parameters (string return)
        static string BirthdayMethod(string name, int age, string status)
        {
            return $"Happy Birthday : {name}, \nYou are {age} years old. \nYou are {status}.";
        }

        // Method accepting variable number of arguments via 'params'
        static double ParamsMethod(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            return total;
        }
    }
}