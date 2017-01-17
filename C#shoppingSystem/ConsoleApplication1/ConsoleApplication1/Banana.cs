using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Banana:ProductFather
    {
        public Banana(string id, double price, string Name)
            : base(id, price, Name)
        {

        }
    }
}
