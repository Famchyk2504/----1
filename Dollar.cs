using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_v24_4_
{
    internal class Dollar : Currency
    {
        private const double rate = 40; // курс долара до гривні

        public Dollar(double amount) : base(amount) { }

        public override double ToUAH()
        {
            return amount * rate;
        }

        public override string Print()
        {
            return $"{amount} USD = {ToUAH()} UAH";
        }
    }
}
