using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenManagement
{
    abstract class Employee
    {
        public string Name { get; set; }
        public int SalaryInUSD { get; set; }
        public DateTime BirthDate { get; set; }

        public float TaxRate { get; } = 0.99F;
        
        public void CalculateTax()
        {
            Console.WriteLine($"My name is {Name}, my salary is {SalaryInUSD}, and my TAX is ${SalaryInUSD * TaxRate}");
        }
    }
}
