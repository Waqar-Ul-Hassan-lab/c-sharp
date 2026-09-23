using System;

namespace VariablesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos;
            anos = 25;
            char letter = 'M';
            string name = "Waqar Hassan";

            Console.WriteLine("Your anos is " + anos);
            Console.WriteLine("Your initial is " + letter);
            Console.WriteLine("Your name is " + name);


            Console.WriteLine("=================================================");


            double a = 5.4;
            int b = Convert.ToInt32(a);
            Console.WriteLine("Your height is now : " + b);
            Console.WriteLine("The data type of a is now : " + a.GetType());
            Console.WriteLine("The data type of a is now : " + a.GetType().Name);
            Console.WriteLine("The data type of b is now : " + b.GetType());
            Console.WriteLine("The data type of b is now : " + b.GetType().Name);


            Console.WriteLine("=================================================");


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter your name : ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello," + userInput);
            Console.WriteLine("You are : " + age + " years old");


            Console.WriteLine("=================================================");


            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            Console.WriteLine("Random number between 1 and 100: " + randomNumber);
            double randomDouble = random.NextDouble();
            Console.WriteLine("Random double between 0.0 and 1.0: " + Math.Round((randomDouble), 5));


            Console.WriteLine("=================================================");


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