using System;
using static System.Console;

namespace StringFormatNumber
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // D : Decimal
            WriteLine("Decimal: {0:D}", 123);
            WriteLine("Decimal: {0:D5}", 123);

            // X : HeaxaDecimal
            WriteLine("Decimal: 0x{0:X}", 0xFF1234);
            WriteLine("Decimal: 0x{0:X}", 0xFF1234);

            // N : Number
            WriteLine("Number: {0:N}", 123456789);
            WriteLine("Number: {0:N0}", 123456789);

            // F : Fixed Point
            WriteLine("Fixed Point: {0:F}", 123.45);
            WriteLine("Fixed Point: {0:F5}", 123.456);

            // E : Engineering
            WriteLine("Engineering: {0:E}", 123.456789);
        }
    }
}
