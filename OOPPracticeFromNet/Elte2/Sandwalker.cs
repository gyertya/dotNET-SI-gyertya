namespace Elte2
{
    internal class Sandwalker : Creature
    {
        public Sandwalker(string name):base()
        {
            this.Name = name;
            this.MaxWater = 8;
        }
        public override void Move(Weather weather)
        {
            if (!IsLiving) return;

            switch (weather)
            {
                case Weather.Sunny: Distance += 3;
                    break;
                case Weather.Cloudy: Distance++;
                    break;
                case Weather.Rainy:
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
                case Weather.Sunny: Water--;
                    break;
                case Weather.Cloudy:
                    break;
                case Weather.Rainy: Water += 3;
                    break;
                default:
                    break;
            }
            this.CheckState();
        }
    }
}