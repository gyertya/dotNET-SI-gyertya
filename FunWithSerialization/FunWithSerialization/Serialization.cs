using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithSerialization
{
    [Serializable]
    public class MyObject
    {
        public int n1;
        public int n2;
        public string s1;
        private string s2;

        public override string ToString()
        {
            return $"{this.n1.ToString()}, {this.n2.ToString()}, {this.s1}";
        }
    }
}
