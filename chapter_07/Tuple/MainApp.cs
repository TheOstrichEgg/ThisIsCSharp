using System;

namespace Tuple
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // UnNamed Tuple
            var a = ("SuperMan", 9999);
            Console.WriteLine($"{a.Item1}, {a.Item2}");

            // Named Tuple
            var b = (Name: "SpiderMan", Age: 17);
            Console.WriteLine($"{b.Name}, {b.Age}");

            // Decomposition 1
            var (name, age) = b;
            Console.WriteLine($"{name}, {age}");

            // Decomposition 2
            var (name2, age2) = ("BatMan", 34);
            Console.WriteLine($"{name2}, {age2}");

            // Named Tuple = UnNamed Tuple
            b = a;
            Console.WriteLine($"{b.Name}, {b.Age}");
        }
    }
}
