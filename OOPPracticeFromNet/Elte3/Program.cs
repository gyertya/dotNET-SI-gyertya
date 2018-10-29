using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elte3
{
    class Program
    {
        static void Main(string[] args)
        {
            KinderGarden kinderGarden = new KinderGarden();

            kinderGarden.AddTeacer(new Teacher("Teacher"));

            kinderGarden.AddChild(new Lively());
            kinderGarden.AddChild(new Comfortable());
            kinderGarden.AddChild(new Musican());
        }
    }
}
