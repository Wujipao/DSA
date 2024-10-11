using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class StackTest
    {
        public static void Main(string[] args)
        {
            StackClass<int> stck = new StackClass<int>(5);

            stck.Push(10);
            stck.Push(20);
            stck.Push(30);
            Console.WriteLine($"Popped: {stck.Pop()}")
            Console.WriteLine($"Peeked: {stck.Peek()}")
            stck.Display();
        }
    }
}
