using System;

namespace IntegralConversion
{
    class MainApp
    {
        static void Main(string[] args)
        {
            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int x = 128; // int.MaxValue + 1
            Console.WriteLine(x);

            sbyte y = (sbyte)x; // overflow
            Console.WriteLine(y);
        }
    }
}
