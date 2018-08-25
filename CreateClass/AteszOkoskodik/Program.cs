using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AteszOkoskodik
{
    class Program
    {
        static void Main(string[] args)
        {
            Person gazsi = new Person("Gazsi");
            gazsi.BirthDate = new DateTime(1990, 5, 21);
            gazsi.Gender = Gender.Male;
        }
    }
}
