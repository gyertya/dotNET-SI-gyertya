using System.Collections.Generic;

namespace Elte2
{
    public class Race
    {
        public List<Creature> creatures;
        public Race()
        {
            creatures = new List<Creature>();
        }

        public void NewDay(Weather weather)
        {
            foreach (Creature creature in creatures)
            {
                creature.UseWater(weather);
                creature.Move(weather);
            }
        }

        public void AddCreature(Creature creature)
        {
            creatures.Add(creature);
        }

        public void Winners()
        {
            creatures.Sort((a, b) => b.Distance.CompareTo(a.Distance));
            int i = 0;
            foreach (var creature in creatures)
            {
                System.Console.WriteLine($"{i++}. {creature.Name} (distance: {creature.Distance}, water left:{creature.Water})");
            }
        }
    }
}