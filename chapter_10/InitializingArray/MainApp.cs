using System;

namespace InitializingArray
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[3] { "Saluton", "Hello", "Halo" };
            Console.WriteLine("array1...");
            foreach (string greeting in array1)
                Console.WriteLine($" {greeting}");

            string[] array2 = new string[] { "Saluton", "Hello", "Halo" };
            Console.WriteLine("\narray2...");
            foreach (string greeting in array2)
                Console.WriteLine($" {greeting}");

            string[] array3 = { "Saluton", "Hello", "Halo" };
            Console.WriteLine("\narray3...");
            foreach (string greeting in array3)
                Console.WriteLine($" {greeting}");
        }
    }
}
