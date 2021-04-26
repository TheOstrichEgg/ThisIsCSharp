using System;

namespace SwitchExp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the score");
            int score = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is it retaken Course? (y/n");
            string line = Console.ReadLine();
            bool repeated = line == "y" ? true : false;

            string grade = (int)(Math.Truncate(score / 10.0) * 10) switch
            {
                90 when repeated == true => "B+",
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F"
            };

            Console.WriteLine($"Grade : {grade}");
        }
    }
}