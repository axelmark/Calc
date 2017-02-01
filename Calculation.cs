using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    delegate double CalcDeligate(double a, double b);

    class Calculation
    {
        public double calc(double value1, double value2, string sing)
        {

            return value1 + value2;
        }
    }
}