using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calc = new Calculation();
            Console.OutputEncoding = Encoding.UTF7;
            Console.WriteLine("Введите первое значение: ");
            string value1 = Console.ReadLine();
            Console.WriteLine("Введите знак (+-*/): ");
             string sing = Console.ReadLine();
            Console.WriteLine("Введите второе значение: ");
            string value2 = Console.ReadLine();
 

            double res = calc.calc(Convert.ToDouble(value1), Convert.ToDouble(value2), sing);
            Console.WriteLine($"({value1} {sing} {value2} = {res})");
            Console.ReadLine();
        }
    }
}