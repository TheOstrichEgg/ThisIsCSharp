using System;

namespace IfElse
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("Input Number : ");

            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number < 0)
                Console.WriteLine("Negative");
            else if (number > 0)
                Console.WriteLine("Positive");
            else
                Console.WriteLine("0");

            if (number % 2 == 0)
                Console.WriteLine("Even number");
            else
                Console.WriteLine("Odd number");
        }
    }
}
