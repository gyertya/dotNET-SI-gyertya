using System;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        public int Salary;
        public string Profession;
        public Room Room;

        public string ToString()
        {
            return $"Name: {Name}, DOB: {birthDate}, Gender: {gender}, Salary: {Salary:c}, Prof: {Profession}, Room: {Room.Number}";
        }

        public Employee(string name, DateTime time, int salary, string prof)
        {
            Name = name;
            birthDate = time;
            Salary = salary;
            Profession = prof;
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }
    }
}