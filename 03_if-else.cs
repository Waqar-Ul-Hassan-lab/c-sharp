using System;

namespace IfElseSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------------------------------
            // 1. Basic if-else condition check
            // (Uncomment lines below to test user age prompt)
            // -------------------------------------------------------------
            // Console.Write("Enter your age : ");
            // int age = Convert.ToInt32(Console.ReadLine());
            // if (age > 19) Console.WriteLine("You aren't anymore a teenager");
            // else if (age < 19) Console.WriteLine("You still are a teenager");

            Console.WriteLine("=================================================");

            // -------------------------------------------------------------
            // 2. Multi-branch if / else-if statement
            // -------------------------------------------------------------
            Console.Write("Enter the day of the week : ");
            string day = Console.ReadLine() ?? "";
            day = day.ToLower();

            if (day == "")
            {
                Console.WriteLine("Invalid Input Value");
            }
            else if (day == "monday")
            {
                Console.WriteLine("Today is MONDAY");
            }
            else if (day == "tuesday")
            {
                Console.WriteLine("Today is TUESDAY");
            }
            else if (day == "wednesday")
            {
                Console.WriteLine("Today is WEDNESDAY");
            }
            else if (day == "thursday")
            {
                Console.WriteLine("Today is THURSDAY");
            }
            else if (day == "friday")
            {
                Console.WriteLine("Today is FRIDAY");
            }
            else if (day == "saturday")
            {
                Console.WriteLine("Today is SATURDAY");
            }
            else if (day == "sunday")
            {
                Console.WriteLine("Today is SUNDAY");
            }
            else
            {
                Console.WriteLine("Invalid Day Entered!");
            }

            Console.WriteLine("=================================================");

            // -------------------------------------------------------------
            // 3. Switch statement alternative
            // -------------------------------------------------------------
            Console.Write("Enter the day of the week : ");
            string dayName = Console.ReadLine() ?? "";
            dayName = dayName.ToLower();

            switch (dayName)
            {
                case "monday":
                    Console.WriteLine("Today is MONDAY");
                    break;
                case "tuesday":
                    Console.WriteLine("Today is TUESDAY");
                    break;
                case "wednesday":
                    Console.WriteLine("Today is WEDNESDAY");
                    break;
                case "thursday":
                    Console.WriteLine("Today is THURSDAY");
                    break;
                case "friday":
                    Console.WriteLine("Today is FRIDAY");
                    break;
                case "saturday":
                    Console.WriteLine("Today is SATURDAY");
                    break;
                case "sunday":
                    Console.WriteLine("Today is SUNDAY");
                    break;
                default:
                    Console.WriteLine("Invalid Day Entered!");
                    break;
            }

            Console.WriteLine("=================================================");
        }
    }
}