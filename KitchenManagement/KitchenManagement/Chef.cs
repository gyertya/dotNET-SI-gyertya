using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenManagement
{
    class Chef : Cooker, ICooker
    {
        private static Chef chef;

        public Chef()
        {
        }

        public static Chef CreateNewChef(string name, int salary, DateTime birthDate)
        {
            {
                if (chef == null)
                {
                    chef = new Chef();
                }
                chef.Name = name;
                chef.SalaryInUSD = salary;
                chef.BirthDate = birthDate;
                return chef;
            }
        }

        public void DoCooking()
        {
            Console.WriteLine("Argh argh!");
        }
    }
}
