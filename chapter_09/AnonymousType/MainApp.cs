using System;

namespace AnonymousType
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var a = new { Name = "Michael Jackson", Age = 20 };
            Console.WriteLine($"Name: {a.Name}, Age: {a.Age}");

            var b = new { Subject = "Math", Scores = new int[] { 90, 80, 70, 60 } };
            Console.Write($"Subject: {b.Subject}, Scores:");
            foreach (var score in b.Scores)
                Console.Write($"{score} ");
        }
    }
}
