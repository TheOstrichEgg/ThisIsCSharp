using System;

namespace PositionalPattern
{
    class MainApp
    {
        private static double GetDiscountRate(object client)
        {
            return client switch
            {
                ("Student", int n) when n < 18 => 0.2,
                ("Student", _) => 0.1,
                ("General", int n) when n < 18 => 0.1,
                ("General", _) => 0.05,
                _ => 0.0,
            };
        }

        static void Main(string[] args)
        {
            var alice   = (job: "Student", age: 17);
            var bob     = (job: "Student", age: 23);
            var charlie = (job: "General", age: 15);
            var dave    = (job: "General", age: 21);

            Console.WriteLine($"alice   : {GetDiscountRate(alice)}");
            Console.WriteLine($"bob     : {GetDiscountRate(bob)}");
            Console.WriteLine($"charlie : {GetDiscountRate(charlie)}");
            Console.WriteLine($"dave    : {GetDiscountRate(dave)}");
        }
    }
}
