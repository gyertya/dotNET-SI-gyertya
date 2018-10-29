using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlToCode
{
    interface Orderable
    {
        bool Checkout();

        bool Pay();
    }
}
