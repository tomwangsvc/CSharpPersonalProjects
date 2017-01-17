using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SuperMarket
    {
        WareHouse wh = new WareHouse();
        public SuperMarket() {
            wh.ImportPros("Acer", 1000);
            wh.ImportPros("SamSung", 100);
            wh.ImportPros("SoySauce", 1000);
            wh.ImportPros("Banana", 1000);
        }
        public void AskBuying() {
            Console.WriteLine("what u want");
            string strType = Console.ReadLine();
            Console.WriteLine("how many");
            int count = Convert.ToInt32(Console.ReadLine());
            ProductFather[] pros = wh.GetPros(strType, count);
            double realMoney = GetMoney(pros);
            string input = Console.ReadLine();
            CalFather cal = GetCal(input);
            double totalMoney = cal.GetTotalMoney(realMoney);
            Console.WriteLine("pay {0}",totalMoney);
        
        }
        public double GetMoney(ProductFather[] pros) {
            double realMoney = 0;
            //realMoney=pros[0]*pros.Length;
            for (int i = 0; i < pros.Length; i++)
            {
                realMoney += pros[i].Price;
            }
            return realMoney;
        }
        public CalFather GetCal(string input)
        {
            CalFather cal = null;
            switch (input)
            {
                case "1": cal = new CalNormal();
                    break;
                case "2": cal = new CalRate(0.9);
                    break;
                case "3": cal = new CalRate(0.85);
                    break;
                case "4": cal = new CalMN(300, 50);
                    break;
                case "5": cal = new CalMN(500, 100);
                    break;
            }
            return cal;
        }
        public void ShowPros()
        {
            wh.ShowPros();
        }
    }
}
