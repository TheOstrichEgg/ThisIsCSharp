using System;
using System.Linq;

namespace MinMaxAvg
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile() { Name = "Michael Jackson",   Height = 176 },
                new Profile() { Name = "Bob Marley",        Height = 170 },
                new Profile() { Name = "Stevie Wonder",     Height = 182 },
                new Profile() { Name = "Cyndi Lauper",      Height = 160 },
                new Profile() { Name = "Mariah Carey",      Height = 170 },
            };

            var heightStat = from profile in arrProfile
                             group profile by profile.Height < 175 into g
                             select new
                             {
                                 Group = g.Key == true ? "175 under" : "175 over ",
                                 Count = g.Count(),
                                 Max = g.Max(profile => profile.Height),
                                 Min = g.Min(profile => profile.Height),
                                 Average = Convert.ToInt32(g.Average(profile => profile.Height)),
                             };

            foreach (var stat in heightStat)
            {
                Console.Write("{0} - Count: {1}, Max: {2}, ",
                    stat.Group, stat.Count, stat.Max);
                Console.WriteLine("Min: {0}, Average: {1}",
                    stat.Min, stat.Average);
            }
        }
    }
}
