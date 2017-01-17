using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Computer
    {
        public string Fist
        {
            get;
            set;
        }
        public int ShowFist() {
            Random r = new Random();
            int rNumber = r.Next(1, 4);
            switch (rNumber) {
                case 1: this.Fist = "rock";
                    break;
                case 2: this.Fist = "scissor";
                    break;
                case 3: this.Fist = "paper";
                    break;
            }
            return rNumber;
        }
    }
}
