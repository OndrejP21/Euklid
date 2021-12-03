using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euklid
{
    public class Euklid
    {
        public Euklid()
        {

        }

        public int Divisor(int number1, int number2)
        {
            int mod = 1;

            while (mod != 0)
            {
                mod = number1 % number2;

                number1 = number2;
                number2 = mod;
            }

            return number1;
        }
    }
}
