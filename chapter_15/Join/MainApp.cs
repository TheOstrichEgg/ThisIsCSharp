using System;
using System.Linq;

namespace Join
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class Product
    {
        public string Title { get; set; }
        public string Star { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile() { Name = "Michael Jackson", Height = 176 },
                new Profile() { Name = "Bob Marley",      Height = 170 },
                new Profile() { Name = "Stevie Wonder",   Height = 182 },
                new Profile() { Name = "Cyndi Lauper",    Height = 160 },
                new Profile() { Name = "Mariah Carey",    Height = 170 },
            };

            Product[] arrProduct =
            {
                new Product() { Title = "Black or White",   Star = "Michael Jackson" },
                new Product() { Title = "Redemption Song",  Star = "Bob Marley" },
                new Product() { Title = "Superstition",     Star = "Stevie Wonder" },
                new Product() { Title = "True Blue",        Star = "Cyndi Lauper" },
                new Product() { Title = "Paranoid",         Star = "Black Sabbath" },
            };

            var listProfile =
                from profile in arrProfile
                join product in arrProduct on profile.Name equals product.Star
                select new
                {
                    Name = profile.Name,
                    Work = product.Title,
                    Height = profile.Height,
                };

            Console.WriteLine("--- Inner Join Result ---");
            foreach (var profile in listProfile)
            {
                Console.WriteLine("Name: {0}, Title: {1}, Height: {2}cm",
                    profile.Name, profile.Work, profile.Height);
            }

            listProfile =
                from profile in arrProfile
                join product in arrProduct on profile.Name equals product.Star into ps
                from product in ps.DefaultIfEmpty(new Product() { Title = "empty" })
                select new
                {
                    Name = profile.Name,
                    Work = product.Title,
                    Height = profile.Height,
                };

            Console.WriteLine("--- Outer Join Result ---");
            foreach (var profile in listProfile)
            {
                Console.WriteLine("Name: {0}, Title: {1}, Height: {2}cm",
                    profile.Name, profile.Work, profile.Height);
            }
        }
    }
}