namespace Elte2
{
    internal class Walker : Creature
    {
        public Walker(string name):base()
        {
            this.Name = name;
            this.MaxWater = 12;
        }

        public override void Move(Weather weather)
        {
            if (!IsLiving) return;

            switch (weather)
            {
                case Weather.Sunny:
                    Distance++;
                    break;
                case Weather.Cloudy:
                    Distance += 2 ;
                    break;
                case Weather.Rainy:
                    Distance++;
                    break;
            }
        }

        public override void UseWater(Weather weather)
        {
            if (!IsLiving) return;

            switch (weather)
            {
                case Weather.Sunny:
                    Water -= 2;
                    break;
                case Weather.Cloudy:
                    Water--;
                    break;
                case Weather.Rainy:
                    Water += 3;
                    break;
                default:
                    break;
            }

            this.CheckState();
        }
    }
}