using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Microsoft .NET Framework 2.0 Application Development Foundation";
            string[] words = str.Split(' ');
            printArray(words);

            Array.Sort(words);
            printArray(words);

            Array.Reverse(words);
            printArray(words);

            Console.ReadLine();
        }

        private static void printArray(string[] words)
        {
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
