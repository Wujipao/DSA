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
            StackClass<string> stck = new StackClass<string>(5);

            stck.Push("hello");
            stck.Push("world");
            stck.Push("i");
            stck.Push("love");
            stck.Push("you");

            string[] arr = new string[5];

            for(int i = 0; i < arr.Length; i++) 
            {
                arr[i] = stck.Pop();
                Console.WriteLine(arr[i]);
            }
        }
    }
}
