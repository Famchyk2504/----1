using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_v24_4_
{
    abstract class Currency
    {
        protected double amount;

        public Currency(double amount)
        {
            this.amount = amount;
        }

        // переведення в гривні
        public abstract double ToUAH();

        // вивід результату
        public abstract string Print();
    }
}
