using System;

namespace PropertiesInInterface
{
    interface INamedValue
    {
        string Name { get; set; }
        string Value { get; set; }
    }

    class NamedValue : INamedValue
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"{Name} : {Value}";
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            NamedValue name   = new NamedValue() { Name = "Name",   Value = "Bob Marley" };
            NamedValue height = new NamedValue() { Name = "height", Value = "180cm" };
            NamedValue weight = new NamedValue() { Name = "weight", Value = "70Kg" };

            // Modify book example
            Console.WriteLine(name);
            Console.WriteLine(height);
            Console.WriteLine(weight);
        }
    }
}
