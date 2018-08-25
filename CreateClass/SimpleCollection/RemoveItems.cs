using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCollection
{
    class RemoveItems
    {
        internal static void NumbersManipulation()
        {
            var Numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int index = 0; index < Numbers.Count; index++)
            {
                if (Numbers[index] % 2 == 1)
                {
                    Numbers.RemoveAt(index);
                }
            }
            Numbers.ForEach(
                number => Console.Write(number + " "));
        }
    }
}
