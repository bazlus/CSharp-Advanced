using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_02._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var operations = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var stack = new Stack<int>(numbers.Take(operations[0]));

            for (int i = 0; i < operations[1]; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(operations[2]))
            {
                Console.WriteLine("true");
            }else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
