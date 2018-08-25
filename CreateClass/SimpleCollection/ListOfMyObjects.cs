using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCollection
{
    class ListOfMyObjects
    {
        internal static void IterateThroughList()
        {
            var TheGalaxies = new List<Galaxy>
            {
                new Galaxy() {Name="Tadpolie", MegaLightYear=400},
                new Galaxy() { Name = "Pinwheel", MegaLightYear = 25 },
                new Galaxy() { Name = "Milky Way", MegaLightYear = 0 },
                new Galaxy() { Name = "Andromeda", MegaLightYear = 3 }
            };

            foreach (var galaxy in TheGalaxies)
            {
                Console.WriteLine($"Galaxy name: {galaxy.Name}; distance from earth: {galaxy.MegaLightYear} in mega light year");
            }

        }

    }

    class Galaxy
    {
        public string Name { get; set; }
        public int MegaLightYear { get; set; }
    }
}
