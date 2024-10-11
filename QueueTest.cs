using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class QueueTest
    {
        static void Main(string[] args)
        {
            QueueClass<int> q = new QueueClass<int>(5);

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);

            q.Dequeue();
            q.Dequeue();

            q.Display();
        }
    }
}
