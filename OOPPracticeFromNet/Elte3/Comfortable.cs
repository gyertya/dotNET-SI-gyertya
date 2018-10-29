using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elte3
{
    public class Comfortable : Child
    {
        protected override void DoActivity(Activity activity)
        {
            switch (activity)
            {
                case Activity.Sing:
                    break;
                case Activity.Ball: satisfyLevel -= 2;
                    break;
                case Activity.Draw: satisfyLevel = 4;
                    break;
                case Activity.Dance: satisfyLevel--;
                    break;
                default:
                    break;
            }
        }
    }
}
