using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class CircularQueue
    {
        int[] queue;
        int size;
        int front;
        int rear;
        int count;

        public CircularQueue(int s)
        {
            this.size = s;
            this.queue = new int[s];
            this.front = 0;
            this.rear = -1;
            this.count = 0;
        }
        public bool isEmpty()
        {
            return count == 0;
        }
        public bool isFull()
        {
            return count == size;
        }
        public void Enqueue(int value)
        {
            if (isFull())
            {
                Console.WriteLine("Your Queue is full.");
            }
            rear = (rear+1) % size;
            queue[rear] = value;
            count++;
            Console.WriteLine("{0} is added to the queue.", value);
        }
        public void Dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Your Queue is empty. Nothing can be dequeued.");
            }
            int dequeued = queue[front];
            front = (front+1) % size;
            count--;
            Console.WriteLine("{0} is dequeued from the queue.", dequeued);
        }
        public void Display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Nothing can be printed out. Queue is Empty.");
            }
            Console.WriteLine("The elements of the queue: ");
            foreach (int i in queue)
            {
                Console.Write(i + " ");
            }
        }
    }
}
