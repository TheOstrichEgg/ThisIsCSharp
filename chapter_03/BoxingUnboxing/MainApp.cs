using System;

namespace BoxingUnboxing
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 123;
            object b = (object)a;
            int c = (int)b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            double x = 3.1414213;
            object y = x;
            double z = (double)y;

            Console.WriteLine(x);
            Console.WriteLine(y); // boxing value at x and save to heap
            Console.WriteLine(z); // unboxing value at y and save to stack
        }
    }
}
