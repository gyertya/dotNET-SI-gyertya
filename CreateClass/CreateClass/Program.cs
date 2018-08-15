using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person myPerson = new Person() { Name = "Gyertya"};
            //myPerson.SetBirthDate(1986, 03, 16);
            //myPerson.gender = Person.Gender.MALE;
            //Console.WriteLine(myPerson.GetBirthDate);
            //Console.WriteLine(myPerson.ToString);
            //Console.ReadLine();
            //Employee myEmployee = new Employee();
            //myEmployee.Name = "Candles";
            //myEmployee.SetBirthDate(88, 1, 1);
            //myEmployee.gender = Person.Gender.MALE;
            //myEmployee.Salary = 100000;
            //myEmployee.Profession = "Junior software developer";
            //myEmployee.roomNumber = 1;
            //Console.WriteLine(myEmployee.ToString);
            //Console.ReadLine();

            Employee Kovacs = new Employee("Géza", DateTime.Now, 1000, "léhűtő");
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.Number = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();

        }
    }
    public class Person
    {
        public DateTime birthDate;

        public Gender gender;

        public enum Gender
        {
            MALE,
            FEMALE
        }

        public DateTime GetBirthDate
        {
            get { return birthDate; }
        }

        public void SetBirthDate(int yy, int mm, int dd)
        {
            birthDate = new DateTime(yy, mm, dd);
        }
        public string Name { get; set; }

        public new string ToString => $"Name: {Name}, DOB: {birthDate}, Gender: {gender}";
    }
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

    class Room
    {
        public int Number { get; set; }

        public Room() { }

        public Room(int nr)
        {
            Number = nr;
        }
    }
}