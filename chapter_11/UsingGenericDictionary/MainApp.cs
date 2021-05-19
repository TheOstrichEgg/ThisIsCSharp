using System;
using System.Collections.Generic;

namespace UsingGenericDictionary
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic["One"]   = "First";
            dic["Two"]   = "Second";
            dic["Three"] = "Third";
            dic["Four"]  = "Fourth";
            dic["Five"]  = "Fifth";

            Console.WriteLine(dic["One"]);
            Console.WriteLine(dic["Two"]);
            Console.WriteLine(dic["Three"]);
            Console.WriteLine(dic["Four"]);
            Console.WriteLine(dic["Five"]);
        }
    }
}
