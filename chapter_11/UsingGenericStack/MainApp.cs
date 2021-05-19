using System;
using System.Collections.Generic;

namespace UsingGenericStack
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Stack<int> queue = new Stack<int>();

            queue.Push(1);
            queue.Push(2);
            queue.Push(3);
            queue.Push(4);
            queue.Push(5);

            while (queue.Count > 0)
                Console.WriteLine(queue.Pop());
        }
    }
}
