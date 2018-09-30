using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_03._Max_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            var maxElements = new Stack<int>();
            maxElements.Push(0);

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(' ').ToArray();

                if (command[0] == "1")
                {
                    stack.Push(int.Parse(command[1]));
                    if (maxElements.Peek() < int.Parse(command[1]))
                    {
                        maxElements.Push(int.Parse(command[1]));
                    }
                }else if (command[0] == "2")
                {
                    
                    if (maxElements.Peek() == stack.Pop())
                    {
                        maxElements.Pop();
                    }
                }
                else
                {
                    Console.WriteLine(maxElements.Peek());
                }
            }
        }
    }
}
