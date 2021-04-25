using System;

namespace IfIf
{
    internal class MainApp
    {
        private static void Main(string[] args)
        {
            Console.Write("Please Input a number : ");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if (number > 0)
            {
                if (number % 2 == 0)
                    Console.WriteLine("Positive even number");
                else
                    Console.WriteLine("Positive odd number");
            }
            else
            {
                Console.WriteLine("0 or negative number");
            }
        }
    }
}