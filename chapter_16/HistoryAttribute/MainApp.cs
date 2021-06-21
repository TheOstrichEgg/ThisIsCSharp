using System;

namespace HistoryAttribute
{
    [System.AttributeUsage(System.AttributeTargets.Class,
        AllowMultiple = true)]
    class History : System.Attribute
    {
        private string programmer;
        public double version;
        public string changes;

        public History(string programmer)
        {
            this.programmer = programmer;
            version = 1.0;
            changes = "First release";
        }

        public string GetProgrammer()
        {
            return programmer;
        }
    }

    [History("Jackson",
        version = 0.1, changes = "2021-06-21 Created class stub")]
    [History("Marley",
        version = 0.2, changes = "2021-06-21 Added Func() Method")]
    class MyClass
    {
        public void Func()
        {
            Console.WriteLine("Func()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Type type = typeof(MyClass);
            Attribute[] attributes = Attribute.GetCustomAttributes(type);

            Console.WriteLine($"{type.Name} change history...");

            foreach (Attribute a in attributes)
            {
                History h = a as History;
                if (h != null)
                    Console.WriteLine("Ver: {0}, Programmer: {1}, Chages: {2}",
                        h.version, h.GetProgrammer(), h.changes);
            }
        }
    }
}
