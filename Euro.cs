using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_v24_4_
{
    internal class Euro: Currency
    {
        private const double rate = 42; 

        public Euro(double amount) : base(amount) { }

        public override double ToUAH()
        {
            return amount * rate;
        }

        public override string Print()
        {
            return $"{amount} EUR = {ToUAH()} UAH";
        }
    }
}
