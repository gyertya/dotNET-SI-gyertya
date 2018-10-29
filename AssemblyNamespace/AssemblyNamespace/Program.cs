using System;
using System.Collections.Generic;

namespace AssemblyNamespace
{
    class Program
    {
        abstract class CarClass
        {
            public virtual int SpeedLimit()
            {
                return 100;
            }
        }
        class Ford : CarClass
        {
            public override int SpeedLimit()
            {
                return base.SpeedLimit()+ 150;
            }
            public static void ProblematicCode()
            {
                CarClass obj = new Ford();
                Ford Obj = new Ford() ;
                int num = obj.SpeedLimit();
                int num2 = Obj.SpeedLimit();
                Console.WriteLine("Speed Limit is (CarClass): " + num);
                Console.WriteLine("Speed Limit is (Ford): " + num2);
            }
        }



        class InterfacesStuff
        {
            internal static void InterfaceStuffMain()
            {
                List<Dog> dogs = new List<Dog>();
                dogs.Add(new Dog("Fido"));
                dogs.Add(new Dog("Bob"));
                dogs.Add(new Dog("Adam"));
                dogs.Sort();
                foreach (Dog dog in dogs)
                    Console.WriteLine(dog.Describe());
                Console.ReadKey();
            }
        }

        interface IAnimal
        {
            string Describe();

            string Name
            {
                get;
                set;
            }
        }

        class Dog : IAnimal, IComparable
        {
            private string name;

            public Dog(string name)
            {
                this.Name = name;
            }

            public string Describe()
            {
                return "Hello, I'm a dog and my name is " + this.Name;
            }

            public int CompareTo(object obj)
            {
                if (obj is IAnimal)
                    return this.Name.CompareTo((obj as IAnimal).Name);
                return 0;
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }





        static void Main(string[] args)
        {
            Pub pub = new Pub();
            Bartender bartender = new Bartender("Panni", "Mama", new DateTime(1956, 05, 30), pub);

            Waiter waiter = new Waiter("Karcsi", "Bá", new DateTime(1954, 02, 18), pub);
            waiter = new Waiter("Zoli", "Fiú", new DateTime(1962, 04, 11), pub);
            waiter = new Waiter("Ricsi", "Lány", new DateTime(1962, 04, 11), pub);

            Long beer = new Long("Beer", 2.0F, pub);

            Short palinka = new Short("Pálinka", 2.5F, pub);

            Ford.ProblematicCode();

            InterfacesStuff.InterfaceStuffMain();
        }
    }
}
