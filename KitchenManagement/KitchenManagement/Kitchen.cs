using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenManagement
{
    class Kitchen
    {
        public void Simulation()
        {
            Chef SimChef = Chef.CreateNewChef("Simulation John", 1000, new DateTime(1986, 03, 16)); //TODO How to make a normal singleton?
            Cook SimCook1 = new Cook("Simulation Cook", 700, new DateTime(1989, 05, 06));
            Cook SimCook2 = new Cook("Bad Simulation Cook", 400, new DateTime(1988, 05, 25));

            Helper SimHelper1 = new Helper("Simulation Helper", 350, new DateTime(1956, 01, 23));
            Helper SimHelper2 = new Helper("Better Simulation Helper", 450, new DateTime(1965, 11, 06));
            Helper SimHelper3= new Helper("Favourite Simulation Helper", 1100, new DateTime(1985, 09, 01));

            Console.WriteLine(SimHelper1.HaveIngredient(Ingredient.CARROT));

            SimHelper1.Ingredients[0]++;

            SimHelper3.CalculateTax();

            Console.WriteLine(SimHelper1.HaveIngredient(Ingredient.CARROT));
        }
    }
}
