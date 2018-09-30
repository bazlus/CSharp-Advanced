using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_07._Balanced_Parentheces
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<char>(input);
            var queue = new Queue<char>(input);

            if (stack.Count % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (queue.Peek() == '[')
                {
                    if (stack.Peek() != ']')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else if (queue.Peek() == '{')
                {
                    if (stack.Peek() != '}')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else if (queue.Peek() == '(')
                {
                    if (stack.Peek() != ')')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                queue.Dequeue();
                stack.Pop();
            }

            Console.WriteLine("YES");

        }
    }
}
