using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        public class Generic<T, Q>
        {
            public T Field;
            public Q Field2;
        }

        static void Main(string[] args)
        {
            SomeArrayListTest();

            Generic<string, int> g = new Generic<string, int>();
            g.Field = "A string";
            g.Field2 = 12;
            Console.WriteLine("Generic.Field            = {0}", g.Field);
            Console.WriteLine("Generic.Field.GetType()  = {0}", g.Field.GetType().FullName);
            Console.WriteLine("Generic.Field2           = {0}", g.Field2);
            Console.WriteLine("Generic.Field2.GetType() = {0}", g.Field2.GetType().FullName);
        }

        private static void SomeArrayListTest()
        {
            var MyArrayList = new System.Collections.ArrayList
            {
                1,
                "Text"
            };

            int notworking = 0;
            foreach (var item in MyArrayList)
            {
                Console.WriteLine(item.GetType());
                try
                {
                    notworking += (int)item;
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine("InvavlidCastException thrown....");
                }
            }
        }
    }
}
