using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------------------------------
            // Interfaces define contracts that implementing classes must fulfill.
            // Unlike classes, a C# class can implement multiple interfaces.
            // -------------------------------------------------------------
            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            Console.WriteLine("--- Prey Actions ---");
            rabbit.flee();

            Console.WriteLine("\n--- Predator Actions ---");
            hawk.Hunt();

            Console.WriteLine("\n--- Multiple Interfaces (Prey & Predator) ---");
            fish.flee();
            fish.Hunt();
        }
    }

    // Interface defining prey behavior
    interface Iprey
    {
        void flee();
    }

    // Interface defining predator behavior
    interface Ipredator
    {
        void Hunt();
    }

    // Rabbit implements single interface: Iprey
    class Rabbit : Iprey
    {
        public void flee()
        {
            Console.WriteLine("The Rabbit runs away");
        }
    }

    // Hawk implements single interface: Ipredator
    class Hawk : Ipredator
    {
        public void Hunt()
        {
            Console.WriteLine("The Hawk is searching for food");
        }
    }

    // Fish implements multiple interfaces: Ipredator and Iprey
    class Fish : Ipredator, Iprey
    {
        public void flee()
        {
            Console.WriteLine("The fish swims away");
        }

        public void Hunt()
        {
            Console.WriteLine("The Fish is searching for smaller fish");
        }
    }
}