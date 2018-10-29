using System;

namespace Elte2
{
    public abstract class Creature
    {
        protected int MaxWater;
        public int Water { get; protected set; }
        public int Distance { get; protected set; }
        public string Name { get; protected set; }
        protected bool IsLiving = true;
        private static Random rnd = new Random();

        public abstract void UseWater(Weather weather);
        public abstract void Move(Weather weather);

        public Creature()
        {
            Water = rnd.Next(1,8);
        }

        public void CheckState()
        {
            if (Water > MaxWater) Water = MaxWater;
            if (Water <= 0) IsLiving = false;
        }
    }
}