using System;

namespace AssemblyNamespace
{
    class Waiter : Employee
    {
        public Waiter(string firstName, string lastName, DateTime dateOfBirth, Pub pub) : base(firstName, lastName, dateOfBirth)
        {
            pub.Waiters.Add(this);
        }
    }
}