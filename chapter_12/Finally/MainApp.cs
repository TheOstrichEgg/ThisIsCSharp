using System;

namespace Finally
{
    class MainApp
    {
        static int Divide(int dividend, int divisor)
        {
            try
            {
                Console.WriteLine("Divide() Start");
                return dividend / divisor;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide() error occured");
                throw e;
            }
            finally{
                Console.WriteLine("Divide() end");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Input dividend: ");
                String temp = Console.ReadLine();
                int dividend = Convert.ToInt32(temp);

                Console.Write("Input divisor: ");
                temp = Console.ReadLine();
                int divisor = Convert.ToInt32(temp);

                Console.WriteLine("{0}/{1} = {2}",
                    dividend, divisor, Divide(dividend, divisor));
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Program terminated...");
            }
        }
    }
}
