using System;

namespace BasicAttribute
{
    class MyClass
    {
        [Obsolete("OldMethod() was deprecated, Use NewMethod()]")]
        public void OldMethod()
        {
            Console.WriteLine("I'm old");
        }

        public void NewMethod()
        {
            Console.WriteLine("I'm new");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.OldMethod();
            obj.NewMethod();
        }
    }
}
