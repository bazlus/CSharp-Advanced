using System;
using System.Collections.Generic;

namespace Exersice_Sets_and_Dictionaries
{
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var uniqueUsernames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                uniqueUsernames.Add(name);
            }

            foreach (var username in uniqueUsernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
