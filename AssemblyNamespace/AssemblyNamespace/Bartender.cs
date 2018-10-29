using System;

namespace AssemblyNamespace
{
    internal class Bartender : Employee
    {
        public Bartender(string fistName, string lastName, DateTime dateOfBirth, Pub pub) : base(fistName, lastName, dateOfBirth)
        {
            pub.Bartenders.Add(this);
        }
    }
}