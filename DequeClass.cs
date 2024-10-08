﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class DequeClass<T>
    {
        private LinkedList<T> list; 

        public DequeClass()
        {
            this.list = new LinkedList<T>();
        }
        public void AddFront(T front)
        {
            list.AddFirst(front);
        }
        public void AddBack(T back)
        {
            list.AddLast(back);
        }
        public T RemoveFront()
        {
            if (list.Count == 0)
            {
                throw new Exception("Deque is empty.");
            }
            T value = list.First.Value;
            list.RemoveFirst();
            return value;
        }
        public T RemoveBack()
        {
            if (list.Count == 0)
            {
                throw new Exception("Deque is empty.");
            }
            T value = list.Last.Value;
            list.RemoveLast();
            return value;
        }
        public int Count
        {
            get { return list.Count; }
        }
    }
}
