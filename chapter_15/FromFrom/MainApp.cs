using System;
using System.Linq;

namespace FromFrom
{
    class Class
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Class[] arrClass =
            {
                new Class { Name = "#1", Score = new int[] { 99, 80, 70, 24 } },
                new Class { Name = "#2", Score = new int[] { 60, 45, 87, 72 } },
                new Class { Name = "#3", Score = new int[] { 92, 30, 85, 94 } },
                new Class { Name = "#4", Score = new int[] { 90, 88, 00, 17 } },
            };

            var classes = from c in arrClass
                         from s in c.Score
                         where s < 60
                         orderby s
                         select new { c.Name, Lowest = s };

            foreach (var c in classes)
                Console.WriteLine($"Fail : {c.Name} ({c.Lowest})");
        }
    }
}
