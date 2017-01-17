using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Player
    {
        public int ShowFist(string fist) {
            int num = 0;
            switch (fist) { 
                case "rock":num=1;
                    break;
                case "scissor": num = 2;
                    break;
                case "paper": num = 3;
                    break;
            }
            return num;
        }
    }
}
