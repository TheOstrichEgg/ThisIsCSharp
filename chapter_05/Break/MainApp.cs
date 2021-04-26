using System;

namespace Break
{
    class MainApp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Continue? (yes / no) : ");
                string answer = Console.ReadLine();

                if (answer == "no")
                    break;
            }
        }
    }
}
