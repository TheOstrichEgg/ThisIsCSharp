using System;

namespace Switch
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("Please pick one/ (Sun, Mon, Tue, Wed, Thu, Fri, Sat) : ");
            string day = Console.ReadLine();

            switch (day)
            {
                case "Sun":
                    Console.WriteLine("Sunday");
                    break;
                case "Mon":
                    Console.WriteLine("Monday");
                    break;
                case "Tue":
                    Console.WriteLine("Tuesday");
                    break;
                case "Wed":
                    Console.WriteLine("Wednesday");
                    break;
                case "Thu":
                    Console.WriteLine("Thursday");
                    break;
                case "Fri":
                    Console.WriteLine("Friday");
                    break;
                case "Sat":
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine($"{day} is invalid input.");
                    break;
            }
        }
    }
}
