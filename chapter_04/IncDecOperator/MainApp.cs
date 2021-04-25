using System;

namespace IncDecOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.Write(a++);
            Console.Write(++a);

            Console.Write(a--);
            Console.Write(--a);
        }
    }
}
