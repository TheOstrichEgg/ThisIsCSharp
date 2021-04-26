using System;

namespace Switch2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            object obj = null;

            string s = Console.ReadLine();
            if (int.TryParse(s, out int out_i))
                obj = out_i;
            else if (float.TryParse(s, out float out_f))
                obj = out_f;
            else
                obj = s;

            switch (obj)
            {
                case int i:
                    Console.WriteLine($"{i} is a integer type.");
                    break;
                case float f:
                    Console.WriteLine($"{f} is a float type.");
                    break;
                default:
                    Console.WriteLine($"{obj} is an unknown type.");
                    break;
            }
        }
    }
}
