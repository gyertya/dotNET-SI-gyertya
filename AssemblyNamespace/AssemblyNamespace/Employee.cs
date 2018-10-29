using System;

namespace AssemblyNamespace
{
    internal abstract class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; }

        public Employee(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }


    }
}