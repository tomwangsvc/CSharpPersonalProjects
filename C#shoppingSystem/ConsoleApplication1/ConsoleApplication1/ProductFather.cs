using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ProductFather
    {
        public double Price
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string ID
        {
            get;
            set;
        }
        public ProductFather(string id, double price, string Name)
        {
            this.ID = id;
            this.Price = price;
            this.Name = Name;
        }
    }
}
