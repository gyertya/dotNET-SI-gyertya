using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequentialCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyQueue = new Queue<string>(new[] { "First", "Second", "Third", "Fourth" });
            //MyQueue.Enqueue("First");
            //MyQueue.Enqueue("Second");
            //MyQueue.Enqueue("Third");
            //MyQueue.Enqueue("Fourth");

            foreach (var item in MyQueue)
            {
                Console.WriteLine(item);
            }

            while (MyQueue.Count > 0)
            {
                MyQueue.Dequeue();
            }

            var MyStack = new Stack<string>(new[] { "First", "Second", "Third", "Fourth" });

            foreach (var item in MyStack)
            {
                Console.WriteLine(item);
            }

            while (MyStack.Count > 0) {
                MyStack.Pop();
            }

        }   
    }
}
