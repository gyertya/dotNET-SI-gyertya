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
            Person myPerson = new Person() { Name = "Gyertya"};
            myPerson.SetBirthDate(1986, 03, 16);
            myPerson.gender = Person.Gender.MALE;
            Console.WriteLine(myPerson.GetBirthDate);
            Console.WriteLine(myPerson.ToString);
            Console.ReadLine();
            Employee myEmployee = new Employee();
            myEmployee.Name = "Candles";
            myEmployee.SetBirthDate(88, 1, 1);
            myEmployee.gender = Person.Gender.MALE;
            myEmployee.Salary = 100000;
            myEmployee.Profession = "Junior software developer";
            Console.WriteLine(myEmployee.ToString);
            Console.ReadLine();
            Employee myOldEmployee = myPerson;

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

        public string ToString => $"Name: {Name}, DOB: {birthDate}, Gender: {gender}";
    }
    class Employee : Person
    {
        public int Salary;
        public string Profession;

        public string ToString => $"Name: {Name}, DOB: {birthDate}, Gender: {gender}, Salary: {Salary}, Prof: {Profession}";
    }
}