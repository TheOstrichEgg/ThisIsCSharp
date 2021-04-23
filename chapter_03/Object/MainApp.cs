using System;

namespace Object
{
    class MainApp
    {
        static void Main(string[] args)
        {
            object a = 123;
            object b = 3.141592653589793238462643382379m;
            object c = true;
            object d = "Hello World";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
