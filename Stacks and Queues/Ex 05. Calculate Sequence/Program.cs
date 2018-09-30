using System;
using System.Collections.Generic;

namespace Ex_05._Calculate_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            long currentInput = long.Parse(Console.ReadLine());
            var queue = new Queue<long>();

            queue.Enqueue(currentInput);
            int count = 0;
            while (count < 25)
            {
                long inputTwo = queue.Peek() + 1;
                long inputThree = 2 * queue.Peek() + 1;
                long inputFour = queue.Peek() + 2;
                queue.Enqueue(inputTwo);
                queue.Enqueue(inputThree);
                queue.Enqueue(inputFour);
                Console.Write(queue.Dequeue() + " ");
                count++;
                
            }

            for (int i = 0; i < 50 - count; i++)
            {
                Console.Write(queue.Dequeue() + " ");
            }


        }
    }
}
