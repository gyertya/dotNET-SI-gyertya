using System.Collections.Generic;

namespace AssemblyNamespace
{
    internal class Pub
    {
        public List<Bartender> Bartenders { get; set; }
        public List<Waiter> Waiters { get; set; }
        public List<Long> Longs { get; private set; }
        public List<Short> Shorts { get; private set; }

        public Pub()
        {
            Bartenders = new List<Bartender>();
            Waiters = new List<Waiter>();
            Longs = new List<Long>();
            Shorts = new List<Short>();
        }
    }
}