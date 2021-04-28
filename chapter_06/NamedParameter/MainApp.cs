using System;

namespace NamedParameter
{
    class MainApp
    {
        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"Name: {name}, Phone: {phone}");
        }

        static void Main(string[] args)
        {
            PrintProfile(name: "Michael Jackson", phone: "000-0000-0000");
            PrintProfile(phone: "000-0000-0000", name: "Stevie Wonder");
            PrintProfile("Bob Marley", "000-0000-0000");
            PrintProfile("Lady Gaga", phone: "000-0000-0000");
        }
    }
}
