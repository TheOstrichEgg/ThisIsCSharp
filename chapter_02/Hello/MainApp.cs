using System;
using static System.Console;

namespace Hello
{
    class MainApp
    {
        // Program entry point
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Use this like : Hello.exe <name>");
                return;
            }

            WriteLine("Hello, {0}", args[0]);
        }
    }
}