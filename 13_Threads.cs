using System;
using System.Threading;

namespace ThreadsConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------------------------------
            // Multithreading in C#
            // Allows concurrent execution of multiple paths of code.
            // -------------------------------------------------------------

            // Reference to the primary execution thread
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "MainThread";

            // Creating worker threads with method delegates
            Thread thread1 = new Thread(CounterUp);
            Thread thread2 = new Thread(CounterDown);

            // Note: If the target method requires arguments, use a lambda expression:
            // Thread thread1 = new Thread(() => CounterUpWithParam("CountUp"));

            // Start threads concurrently
            thread1.Start();
            thread2.Start();

            Console.WriteLine(mainThread.Name + " thread is Done.");
        }

        // Countdown timer running on thread2
        public static void CounterDown()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Timer #1 : " + i + " seconds");
                Thread.Sleep(1000); // Pauses thread for 1000ms (1 second)
            }
            Console.WriteLine("Timer 1 has completed.");
        }

        // Count-up timer running on thread1
        public static void CounterUp()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Timer #2 : " + i + " seconds");
                Thread.Sleep(1000); // Pauses thread for 1000ms (1 second)
            }
            Console.WriteLine("Timer 2 has completed.");
        }
    }
}