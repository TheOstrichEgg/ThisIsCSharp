using System;

namespace Return
{
    class MainApp
    {
        static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void PrintProfile(string name, string phone)
        {
            if (name == "")
            {
                Console.WriteLine("Please enter your name.");
                return;
            }

            Console.WriteLine($"Name: {name}, Phone: {phone}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"10th number of Fibonacci number: {Fibonacci(10)}");

            PrintProfile("", "123-456");
            PrintProfile("PSH", "123-456");
        }
    }
}
