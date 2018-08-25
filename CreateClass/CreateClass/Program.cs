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

            Employee kovacs = new Employee("Géza", DateTime.Now, 1000, "léhűtő");
            kovacs.Age = 12;

            kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)kovacs.Clone();
            Kovacs2.Room.Number = 112;
            Console.WriteLine(kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();

        }
    }
}