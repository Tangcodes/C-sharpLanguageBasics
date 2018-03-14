using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the following constants and variables and set their initial values as indicated
            const byte sample1 = 0x3A;
            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            const float acceleration = 9.800f;
            float mass = 14.6f;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            const char integral = '\u222B';
            const string greeting = "Hello";
            string name = "Karen";

            // Compare sample1 to sample2
            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal");
            }
            else
            {
                Console.WriteLine("The samples are not equal");
            }

            // HeartRate 
            if (heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal");
            }
            else
            {
                Console.WriteLine("Heart rate is not normal");
            }

            // Deposits 
            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor");
            }

            // Declare a variable called force that is assigned to the mass times the acceleration
            var force = mass * acceleration;
            Console.WriteLine("force = " + force);

            // Display the value of distance followed by “ is the distance.”
            Console.WriteLine(distance + " is the distance.");

            // Using lost and expensive
            if (lost && expensive)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            }
            else if (lost && !expensive)
            {
                Console.WriteLine("Here is coupon for 10 % off.");
            }

            // Use the switch/case
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }

            // Using the character constant integral
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(integral + " is an integral");

            // Declare an integer variable age with an initial value of 0
            for (int i = 5; i <= 10; i++)
            {
                Console.WriteLine("i = " + i);
            }
            int age = 0;
            while (age < 6)
            {
                Console.WriteLine("age = " + age++);
            }

            // Display a line that contains the greeting string followed by a space followed by the name string
            Console.WriteLine(greeting + "," + name);

            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}