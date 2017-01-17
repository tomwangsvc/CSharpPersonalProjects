using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class WareHouse
    {
         List<List<ProductFather>> list = new List<List<ProductFather>>();
        public void ShowPros() {
            foreach (var item in list)
            {
                Console.WriteLine("we have:" + item[0].Name + "," + "\t" + "have" + item.Count + "products," + "\t" + "every one is" + item[0].Price);
            }
        }
        public WareHouse()
        {
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }
        public void ImportPros(string strType, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer": list[0].Add(new Acer(Guid.NewGuid().ToString(), 1000, "Acer Laptop"));
                        break;
                    case "SamSung": list[1].Add(new Acer(Guid.NewGuid().ToString(), 1000, "SamSung Laptop"));
                        break;
                    case "SoySauce": list[2].Add(new Acer(Guid.NewGuid().ToString(), 20, "Soy Sauce"));
                        break;
                    case "Banana": list[3].Add(new Acer(Guid.NewGuid().ToString(), 30, "Banana"));
                        break;

                }

            }
        }
        public ProductFather[] GetPros(string strType, int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for (int i = 0; i < pros.Length; i++)
            {
                switch (strType)
                { 
                    case "Acer":
                        pros[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "SamSung":
                        pros[i] = list[0][0];
                        list[1].RemoveAt(0);
                        break;
                    case "SoySauce":
                        pros[i] = list[0][0];
                        list[2].RemoveAt(0);
                        break;
                    case "Banana":
                        pros[i] = list[0][0];
                        list[3].RemoveAt(0);
                        break;
                }
            }
            return pros;
        }
    }
}
