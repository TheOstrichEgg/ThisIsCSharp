using System;

namespace UsingParams
{
    class MainApp
    {
        static int Sum(params int[] args)
        {
            Console.Write("summing...");

            int sum = 0;

            for (int i = 0; i < args.Length; i++)
            {
                if (i > 0)
                    Console.Write(", ");

                Console.Write(args[i]);
            }
            Console.WriteLine();

            return sum;
        }
        static void Main(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
