namespace AssemblyNamespace
{
    internal class Long : Drink
    {
        public Long(string name, float price, Pub pub) : base(name, price)
        {
            pub.Longs.Add(this);
        }
    }
}