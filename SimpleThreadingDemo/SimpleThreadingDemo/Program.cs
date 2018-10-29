using System;
using System.Threading;

namespace SimpleThreadingDemo
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var thread1 = new Thread(Count);
            var thread2 = new Thread(Count);
            thread1.Start();
            thread2.Start();
        }

        private static void Count()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Counter {i}: Thread-{Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            }
        }
    }
}