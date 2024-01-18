using System;

namespace BasicCSharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their name
            Console.WriteLine("What is your name?");

            // Read the name from the console
            string name = Console.ReadLine();

            // Greet the user
            Console.WriteLine("Hello " + name + "!");

            // Keep the console window open
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

