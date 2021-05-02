using System;

namespace ReadonlyMethod
{
    struct ACSetting
    {
        public double currentInCelcius;
        public double target;

        public readonly double GetFarenheit()
        {
            target = currentInCelcius * 1.8 + 32; // compile Error
            return target;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            ACSetting acs;
            acs.currentInCelcius = 25;
            acs.target = 25;


            Console.WriteLine($"{acs.GetFarenheit()}");
            Console.WriteLine($"{acs.target}");
        }
    }
}
