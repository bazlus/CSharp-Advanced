using System;
using System.Collections;
using System.Collections.Generic;

namespace Ex_09._Stack_Fibonacii
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stackFib = new Stack<long>();
            stackFib.Push(0);
            stackFib.Push(1);

            for (int i = 0; i < n - 1; i++)
            {
                long prevFib = stackFib.Pop();
                long prevPrev = stackFib.Peek();
                long nextFib = prevFib + prevPrev;
                stackFib.Push(prevFib);
                stackFib.Push(nextFib);
            }

            Console.WriteLine(stackFib.Peek());
        }
    }
}
