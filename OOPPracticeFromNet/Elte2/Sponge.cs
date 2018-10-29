namespace Elte2
{
    internal class Sponge : Creature
    {
        public Sponge(string name):base()
        {
            this.Name = name;
            this.MaxWater = 20;
        }

        public override void Move(Weather weather)
        {
            if (!IsLiving) return;

            switch (weather)
            {
                case Weather.Sunny:
                    break;
                case Weather.Cloudy:
                    Distance++;
                    break;
                case Weather.Rainy:
                    Distance += 3;
                    break;
                default:
                    break;
            }
        }

        public override void UseWater(Weather weather)
        {
            if (!IsLiving) return;

            switch (weather)
            {
                case Weather.Sunny:
                    Water -= 4;
                    break;
                case Weather.Cloudy:
                    Water--;
                    break;
                case Weather.Rainy:
                    Water += 6;
                    break;
                default:
                    break;
            }
            this.CheckState();
        }
    }
}