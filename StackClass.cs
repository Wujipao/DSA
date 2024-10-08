﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class StackClass<T>
    {
        private int count;
        private int size;
        private T[] arr;

        public StackClass(int size)
        {
            this.size = size;
            this.arr = new T[size];
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
        public T Push(T item)
        {
            if (ifFull())
            {
                throw new Exception("Stack is full.");
            }
            arr[count] = item;
            count++;
            return item;
        }
        public T Pop()
        {
            if (ifEmpty())
            {
                throw new Exception("Stack is empty.");
            }
            count--;
            return arr[count];
        }
        public T Peek()
        {
            if (ifEmpty())
            {
                throw new Exception("Stack is empty.");
            }
            return arr[count - 1];
        }

        public void Display()
        {
            if (ifEmpty())
            {
                throw new Exception("Nothing to be displayed.");
            }
            Console.WriteLine("Elements in the Stack:");
            for (int i = count - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public int Count
        {
            get { return count; }
        }
    }
}

