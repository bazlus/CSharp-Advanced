using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Ex_04._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int toAdd = tokens[0];
            int toRemove = tokens[1];
            int toFind = tokens[2];
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var queuq = new Queue<int>(numbers.Take(toAdd));

            for (int i = 0; i < toRemove; i++)
            {
                queuq.Dequeue();
            }

            if (queuq.Count == 0)
            {
                Console.WriteLine(0);
            }else if (queuq.Contains(toFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queuq.Min());
            }    

        }
    }
}
