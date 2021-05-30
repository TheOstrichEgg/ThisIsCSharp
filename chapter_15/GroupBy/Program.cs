using System;
using System.Linq;

namespace GroupBy
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
{
                new Profile() { Name = "Michael Jackson", Height = 176 },
                new Profile() { Name = "Bob Marley", Height = 170 },
                new Profile() { Name = "Stevie Wonder", Height = 182 },
                new Profile() { Name = "Cyndi Lauper", Height = 160 },
                new Profile() { Name = "Mariah Carey", Height = 170 },
            };

            var listProfile = from profile in arrProfile
                              orderby profile.Height
                              group profile by profile.Height < 175 into g
                              select new { GroupKey = g.Key, Profiles = g };

            foreach (var Group in listProfile)
            {
                Console.WriteLine($"Under 175? : {Group.GroupKey}");

                foreach (var profile in Group.Profiles)
                {
                    Console.WriteLine($">>> {profile.Name}, {profile.Height}");
                }
            }
        }
    }
}
