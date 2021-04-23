using System;

namespace Decimal
{
    class MainApp
    {
        static void Main(string[] args)
        {
            float   a = 3.1415_9265_3589_7932_3846f;
            double  b = 3.1415_9265_3589_7932_3846;
            decimal c = 3.1415_9265_3589_7932_3846m;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
