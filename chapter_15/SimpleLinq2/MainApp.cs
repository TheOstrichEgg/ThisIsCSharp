using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleLinq2
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

            var profiles = arrProfile.
                            Where(profile => profile.Height < 175).
                            OrderBy(profile => profile.Height).
                            Select(profile =>
                                new
                                {
                                    Name = profile.Name,
                                    InchHeight = profile.Height * 0.393
                                });

            foreach (var profile in profiles)
                Console.WriteLine($"{profile.Name}, {profile.InchHeight}");
        }
    }
}
