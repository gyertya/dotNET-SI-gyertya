using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenManagement
{
    class Cook : Cooker, ICooker
    {
        public void DoCooking()
        {
            Console.WriteLine($"{this.Name} is cooking.");
        }

        public Cook(string name, int salary, DateTime birthDate)
        {
            Name = name;
            SalaryInUSD = salary;
            BirthDate = birthDate;
        }
    }
}
