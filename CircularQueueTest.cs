using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class CircularQueueTest
    {
        public static void Main(string[] args)
        {
            CircularQueue cqueue = new CircularQueue(5);

            Console.WriteLine("Enter the values in the Queue:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + "st value: ");
                int value = int.Parse(Console.ReadLine());
                cqueue.Enqueue(value);
            }

            cqueue.Display();
            Console.WriteLine();
            Console.WriteLine("Dequeueing...");
            for (int i = 0; i < 5; i++)
            {
                cqueue.Dequeue();
            }
        }
    }
}
