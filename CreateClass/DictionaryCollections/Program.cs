using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyHashtable = new Hashtable(){
                { "0", "zero"},
                { "1", "one"},
                { "2", "two"},
                { "3", "three"},
                { "4", "four"},
                { "5","five"},
                { "6","six"},
                { "7","seven"},
                { "8","eight"},
                { "9","nine"},
            };

            var SeriesOfNumbers = "";
            var AnotherSeriesOfNumbers = "0123456789";

            for (int i = 0; i < MyHashtable.Count; i++)
            {
                SeriesOfNumbers += MyHashtable[i.ToString()] + " ";
            }

            for (int i = 0; i < AnotherSeriesOfNumbers.Length; i++)
            {
                Console.WriteLine(AnotherSeriesOfNumbers[i]);
            }

            Console.WriteLine(SeriesOfNumbers);

            foreach (DictionaryEntry de in MyHashtable)
            {
                Console.WriteLine(de.Key + ": " + de.Value);
            }
        }
    }
}
