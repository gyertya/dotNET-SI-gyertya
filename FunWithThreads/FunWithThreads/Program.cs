using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FunWithThreads
{
    public class Program
    {
        public static void CallToChildThread()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is started");
            int sleepfor = 5000;

            Console.Write($"{Thread.CurrentThread.Name} is running");
            const int dotNumber = 5;
            for (int i = 0; i < dotNumber; i++)
            {
                Thread.Sleep(sleepfor / dotNumber);
                Console.Write(" .");
            }
            Console.WriteLine();
            Console.WriteLine("Done");

        }
        public static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Thread childThread = new Thread(childref);
            childThread.Name = "Child Thread";
            childThread.Start();
        }
    }
}
