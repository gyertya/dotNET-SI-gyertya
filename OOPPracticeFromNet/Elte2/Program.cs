using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Race race = new Race();

            race.AddCreature(new Sandwalker("Sandwalker1"));
            race.AddCreature(new Sponge("Sponge1"));
            race.AddCreature(new Walker("Walker1"));

            Random rnd = new Random();

            int days = 1000;

            for (int i = 0; i < days; i++)
            {
                race.NewDay((Weather)rnd.Next(0,Enum.GetNames(typeof(Weather)).Length));
            }


            race.Winners();
        }
    }
}
