using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elte3
{
    public class Lively : Child
    {
        protected override void DoActivity(Activity activity)
        {
            switch (activity)
            {
                case Activity.Sing: satisfyLevel--;
                    break;
                case Activity.Ball: satisfyLevel = 3;
                    break;
                case Activity.Draw: satisfyLevel--;
                    break;
                case Activity.Dance:
                    break;
                default:
                    break;
            }
        }
    }
}
