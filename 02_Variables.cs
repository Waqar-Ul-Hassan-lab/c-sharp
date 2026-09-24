using System;

namespace VariablesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------------------------------
            // 1. Basic Variable Declarations & Data Types
            // -------------------------------------------------------------
            int age;
            age = 25;
            char letter = 'M';
            string name = "Waqar Hassan";

            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your initial is " + letter);
            Console.WriteLine("Your name is " + name);

            Console.WriteLine("=================================================");

            // -------------------------------------------------------------
            // 2. Type Conversion & Checking Types
            // -------------------------------------------------------------
            double a = 5.4;
            int b = Convert.ToInt32(a); // Rounds and converts double to 32-bit integer

            Console.WriteLine("Your height is now : " + b);
            Console.WriteLine("The data type of a is now : " + a.GetType());
            Console.WriteLine("The data type of a is now : " + a.GetType().Name);
            Console.WriteLine("The data type of b is now : " + b.GetType());
            Console.WriteLine("The data type of b is now : " + b.GetType().Name);

            Console.WriteLine("=================================================");

            // -------------------------------------------------------------
            // 3. Console Colors & User Input
            // -------------------------------------------------------------
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Enter your name : ");
            string userInput = Console.ReadLine() ?? "";

            Console.WriteLine("Enter your age : ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, " + userInput);
            Console.WriteLine("You are : " + userAge + " years old");

            Console.WriteLine("=================================================");

            // -------------------------------------------------------------
            // 4. Random Numbers & Math Rounding
            // -------------------------------------------------------------
            Random random = new Random();
            int randomNumber = random.Next(1, 100); // Generates number between 1 and 99
            Console.WriteLine("Random number between 1 and 100: " + randomNumber);

            double randomDouble = random.NextDouble(); // Generates double between 0.0 and 1.0
            Console.WriteLine("Random double between 0.0 and 1.0: " + Math.Round(randomDouble, 5));

            Console.WriteLine("=================================================");

            // -------------------------------------------------------------
            // 5. String Manipulation Methods
            // -------------------------------------------------------------
            string phoneNumber = "123-456-7890";
            phoneNumber = phoneNumber.Replace("-", " ");
            Console.WriteLine("Phone number: " + phoneNumber);

            Console.WriteLine("=================================================");

            string username = "Waqar Hassan";
            string fullName = username.Insert(0, "#");
            Console.WriteLine("Full name: " + fullName);

            string misterName = username.Insert(0, "Mr.");
            Console.WriteLine("Username: " + misterName);

            Console.WriteLine("=================================================");

            Console.WriteLine("Length of misterName: " + misterName.Length);
            string subString = misterName.Substring(0, 3);
            Console.WriteLine("Substring of misterName: " + subString);

            string lastName = misterName.Substring(9, 6);
            Console.WriteLine("Last name: " + lastName);

            char[] letters = misterName.ToCharArray();

            Console.WriteLine("=================================================");

            // -------------------------------------------------------------
            // 6. Converting String to Character Array & Iterating
            // -------------------------------------------------------------
            Console.Write("Letters by Loop : ");
            for (int i = 0; i < letters.Length; i++)
            {
                Console.Write(letters[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("=================================================");
        }
    }
}