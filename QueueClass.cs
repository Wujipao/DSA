using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class QueueClass<T>
    {
        private T[] arr;
        private int count;
        private int size;
        private int front;

        public QueueClass(int size)
        {
            this.arr = new T[size];
            this.size = size;
            this.count = 0;
            this.front = 0;
        }
        public bool ifEmpty()
        {
            return count == 0;
        }
        public bool ifFull()
        {
            return count == size;
        }
        public T Enqueue(T item)
        {
            if (ifFull())
            {
                throw new Exception("Queue is Full.");
            }
            arr[count] = item;
            count++;
            return item;
        }
        public T Dequeue()
        {
            if (ifEmpty())
            {
                throw new Exception("Queue is empty.");
            }
            T dequeued = arr[front];
            arr[front] = default;
            front = (front + 1) % size;
            count--;
            return dequeued;
        }
        public void Display()
        {
            if (ifEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                int index = (front + i) % size;
                Console.Write(arr[index] + " ");
            }
            Console.WriteLine();
        }

    }
}
