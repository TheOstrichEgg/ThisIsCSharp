using System;
using static System.Console;

namespace StringInterpolation
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string name = "KTT";
            int age = 23;
            WriteLine($"{name,-10}, {age:D3}");

            name = "PNS";
            age = 30;
            WriteLine($"{name}, {age,-10:D3}");

            name = "LBS";
            age = 17;
            WriteLine($"{name}, {(age > 20 ? "Majority" : "Minority")}");
        }
    }
}
