using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var set = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var elements = Console.ReadLine().Split().ToArray();
                foreach (var element in elements)
                {
                    set.Add(element);
                }
            }

            Console.WriteLine(string.Join(' ', set));
        }
    }
}
