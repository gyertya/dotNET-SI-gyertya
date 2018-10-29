namespace AssemblyNamespace
{
    internal class Short : Drink
    {
        public Short(string name, float price, Pub pub) : base(name, price)
        {
            pub.Shorts.Add(this);
        }
    }
}