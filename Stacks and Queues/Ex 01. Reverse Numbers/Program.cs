using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_01._Reverse_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var stringReverser = new Stack<int>(input);

            while (stringReverser.Count > 0)
            {
                Console.Write(stringReverser.Pop() + " ");
            }

            Console.WriteLine();
        }
    }
}
