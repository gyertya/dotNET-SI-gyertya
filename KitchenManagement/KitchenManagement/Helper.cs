using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenManagement
{
    class Helper : Employee
    {
        public int[] Ingredients { get; set; } = new int[3] { 0, 0, 0 };

        public Helper(string name, int salary, DateTime birthDate)
        {
            Name = name;
            SalaryInUSD = salary;
            BirthDate = birthDate;
        }

        public void Yell()
        {
            Console.WriteLine("We are out");
        }

        public bool HaveIngredient(Ingredient ingredient)
        {
            if (Ingredients[(int)ingredient] > 0)
            {
                Ingredients[(int)ingredient]--;
                return true;
            }
            return false;
        }

    }
}
