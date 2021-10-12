using System;
using System.Collections;

namespace task6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack Matrix = new Stack();
            for(int i = 0; i < 9; ++i)
            {
                Matrix.Push(i);
            }
            foreach(Object obj in Matrix)
            {
                Console.WriteLine($"{obj} ");
            }
        }
    }
}
