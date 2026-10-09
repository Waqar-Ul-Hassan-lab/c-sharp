using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================");

            // -------------------------------------------------------------
            // 1. Fixed-Size Array vs Dynamic-Size List
            // Arrays have a fixed length once declared.
            // -------------------------------------------------------------
            string[] foodsArray = new string[3];
            foodsArray[0] = "spinach";
            foodsArray[1] = "potato";
            foodsArray[2] = "peas";
            // foodsArray[3] = "cabbage"; // Error: IndexOutOfRangeException

            Console.WriteLine("Fixed Array Elements:");
            foreach (string item in foodsArray)
            {
                Console.WriteLine(" - " + item);
            }

            Console.WriteLine("======================================");

            // -------------------------------------------------------------
            // 2. Generic List<T> Operations (Dynamic sizing at runtime)
            // -------------------------------------------------------------
            List<string> foodsList = new List<string>();

            // Adding elements
            foodsList.Add("Hamburger");
            foodsList.Add("CheeseBurger");
            foodsList.Add("PepsiDrink");
            foodsList.Add("FingerFries");

            // Removing and inserting at a specific index
            foodsList.Remove("PepsiDrink");
            foodsList.Insert(2, "ZingerBurger");

            Console.WriteLine("Dynamic List Elements:");
            foreach (string item in foodsList)
            {
                Console.WriteLine(" - " + item);
            }

            Console.WriteLine("======================================");

            // Searching and inspecting list items
            Console.WriteLine("CheeseBurger index: " + foodsList.IndexOf("CheeseBurger"));
            Console.WriteLine("ZingerBurger index: " + foodsList.LastIndexOf("ZingerBurger"));
            Console.WriteLine("Contains 'FingerFries'? " + foodsList.Contains("FingerFries"));

            Console.WriteLine("======================================");

            // Sorting in ascending alphabetical order
            Console.WriteLine("Sorted List:");
            foodsList.Sort();
            foreach (string item in foodsList)
            {
                Console.WriteLine(" - " + item);
            }

            Console.WriteLine("======================================");

            // Reversing list order
            Console.WriteLine("Reversed List:");
            foodsList.Reverse();
            foreach (string item in foodsList)
            {
                Console.WriteLine(" - " + item);
            }

            Console.WriteLine("======================================");

            // -------------------------------------------------------------
            // 3. List of Custom Objects (List<Player>)
            // -------------------------------------------------------------
            List<Player> playersList = new List<Player>();

            Player player1 = new Player("Dua Lipa");
            Player player2 = new Player("Rihanna Jade");
            Player player3 = new Player("Taylor Swift");

            playersList.Add(player1);
            playersList.Add(player2);
            playersList.Add(player3);

            // Modifying property through setter
            player1.Name = "James Maccoy";

            Console.WriteLine("Players in List:");
            foreach (Player player in playersList)
            {
                Console.WriteLine(" - " + player.Name);
            }

            Console.WriteLine("======================================");
        }
    }

    // Player class with property encapsulation and validation
    class Player
    {
        private string name;

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid Input: Name cannot be empty.");
                }
                else
                {
                    name = value;
                }
            }
        }

        public Player(string name)
        {
            this.name = name;
        }
    }
}