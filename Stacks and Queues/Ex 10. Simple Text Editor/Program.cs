using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_10._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var builder = new StringBuilder();
            var stack = new Stack<string[]>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ').ToArray();
                var command = tokens[0];

                if (command == "1")
                {
                    string toAppend = tokens[1];
                    builder.Append(toAppend);
                    string[] latestCommand = new string[2] {"1",toAppend};
                    stack.Push(latestCommand);
                }else if (command == "2")
                {
                    int countToRemove = int.Parse(tokens[1]);
                    string removed = builder.ToString().Substring(builder.Length - countToRemove);
                    string[] latestCommand = new string[2] { "2", removed};
                    stack.Push(latestCommand);
                    builder.Remove(builder.Length - countToRemove, countToRemove);
                    
                }else if (command == "3")
                {
                    Console.WriteLine(builder[int.Parse(tokens[1]) - 1]);
                }
                else
                {
                    if (stack.Peek()[0] == "1")
                    {
                        int countToRemove = stack.Pop()[1].Length;
                        int startIndex = builder.Length - countToRemove;
                        if (startIndex < 0)
                        {
                            startIndex = 0;
                        }
                        builder.Remove(startIndex, countToRemove);
                    }
                    else
                    {
                        string toAdd = stack.Pop()[1];
                        builder.Append(toAdd);
                    }
                }

            }
        }
    }
}
