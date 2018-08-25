using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var salmons = new List<string>()
                { "chinooks", "coho", "pink", "sockeye"  };

            // Iterate through salmons by foreach
            Console.WriteLine("--Foreach:");
            WriteSalmonsByForeach(salmons);

            // Iterate through salmons by for
            Console.WriteLine("--For:");
            WriteSalmonsByFor(salmons);

            salmons.Remove("pink");
            Console.WriteLine("--\"pink\" removed:");
            WriteSalmonsByFor(salmons);
        }

        private static void WriteSalmonsByFor(List<string> salmons)
        {
            for (int index = 0; index < salmons.Count; index++)
            {
                Console.Write(salmons[index] + " ");
            }
            Console.WriteLine();
        }

        private static void WriteSalmonsByForeach(List<string> salmons)
        {
            foreach (string salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
            Console.WriteLine();
        }
    }
}
