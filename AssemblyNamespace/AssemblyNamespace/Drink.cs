using System;

namespace AssemblyNamespace
{
    abstract class Drink
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int AvailableQuantity { get; set; }

        public Drink(string name, float price)
        {
            Name = name;
            Price = price;

            Random rnd = new Random();
            AvailableQuantity = rnd.Next(5, 100);
        }
    }
}