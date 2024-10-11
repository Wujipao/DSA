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
        
        public QueueClass(int size)
        {
            this.arr = new T[size];
            this.size = size;
            this.count = 0;
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
            T dequeued = arr[0];
            for (int i = 1; i < count; i++)
            {
                arr[i-1] = arr[i]; //move the elements to the left.
            }
            count--;
            return dequeued;
        }
        public T Peek()
        {
            if (ifEmpty()) 
            {
                throw new Exception("Queue is empty.");
            }
            return arr[0];
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
                Console.Write({arr[i]} + " ");
            }
            Console.WriteLine();
        }

    }
}
