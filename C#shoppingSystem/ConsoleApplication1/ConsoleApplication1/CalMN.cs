﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CalMN:CalFather
    {
        public double M
        {
            get;
            set;
        }
        public double N
        {
            get;
            set;
        }
        public CalMN(double m, double n) {
            this.M = m;
            this.N = n;
        }
        public override double GetTotalMoney(double realMoney)
        {
            if (realMoney >= this.M)
            { return realMoney - (int)(realMoney/this.M)*this.N; }
            else {
                return realMoney;
            }
        }
    }
}
