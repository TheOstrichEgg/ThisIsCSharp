using System;
using System.Collections;

namespace UsingHashtable
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["first"]  = "one";
            ht["second"] = "two";
            ht["third"]  = "three";
            ht["fourth"] = "four";
            ht["fifth"]  = "five";

            Console.WriteLine(ht["first"]);
            Console.WriteLine(ht["second"]); 
            Console.WriteLine(ht["third"]); 
            Console.WriteLine(ht["fourth"]);
            Console.WriteLine(ht["fifth"]); 
        }
    }
}
