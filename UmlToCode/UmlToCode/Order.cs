using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlToCode
{
    class Order : Orderable
    {
        private static int idCounter;
        private int id;
        private string status = "new";

        public Order()
        {
            id = idCounter++;
        }

        public bool Checkout()
        {
            status = "checked";
        }

        public bool Pay()
        {
            status = "payed";
        }

        public string GetStatus()
        {
            throw new NotImplementedException();
        }
    }
}
