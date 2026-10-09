using System;

namespace AdvanceConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================================");

            // -------------------------------------------------------------
            // 1. Enums (Enumerations) & Explicit Type Casting
            // Enums represent a set of named integer constants.
            // -------------------------------------------------------------
            string name = Planets.Earth.ToString();
            int radius = (int)PlanetRadius.Earth; // Explicit cast to retrieve underlying integer value

            Console.WriteLine("Planet Name is : " + name);
            Console.WriteLine("Planet Radius is : " + radius + " Km");

            Console.WriteLine("=======================================");

            // -------------------------------------------------------------
            // 2. Generic Methods (<Thing> / <T>)
            // Generics allow writing reusable, type-safe methods that work with any type.
            // -------------------------------------------------------------
            int[] integers = { 1, 2, 3, 4, 5 };
            double[] decimals = { 1.2, 2.4, 3.2, 4.6, 5.9 };
            string[] stringNumbers = { "1", "2", "3", "4", "5" };

            Console.Write("Integers : ");
            DisplayElements(integers);

            Console.Write("Doubles  : ");
            DisplayElements(decimals);

            Console.Write("Strings  : ");
            DisplayElements(stringNumbers);

            Console.WriteLine("=======================================");
        }

        // Generic method: 'Thing' acts as a placeholder for any concrete type passed in
        public static void DisplayElements<Thing>(Thing[] array)
        {
            foreach (Thing value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }

    // Enum representing planetary positions
    enum Planets
    {
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8,
        Pluto = 9
    }

    // Enum storing approximate planet radii (in km)
    enum PlanetRadius
    {
        Mercury = 1100,
        Venus = 1224,
        Earth = 3443,
        Mars = 4432,
        Jupiter = 22563,
        Saturn = 6553,
        Uranus = 7544,
        Neptune = 2253,
        Pluto = 1255
    }
}