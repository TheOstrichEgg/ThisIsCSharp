using System;

namespace OptionalParameter
{
    class MainApp
    {
        static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine($"Name: {name}, Phone: {phone}");
        }

        static void Main(string[] args)
        {
            PrintProfile("Michael Jackson");
            PrintProfile(name: "Stevie Wonder", phone: "000-0000-0000");
            PrintProfile(name: "Bob Marley");
            PrintProfile(name: "Lady gaga", phone: "000-0000-0000");
        }
    }
}
