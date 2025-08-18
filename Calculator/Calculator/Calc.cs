using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calc
    {
        internal static void operatenum(decimal num1,decimal num2,string operate)
        {
            if (operate == "+")
            { 
                decimal result = num1 + num2;
                Console.WriteLine($"{result}");
            }

            else if (operate == "-")
            {
                decimal result = num1 - num2;
                Console.WriteLine($"{result}");
            }

            else if (operate == "*")
            {
                decimal result = num1 * num2;
                Console.WriteLine($"{result}");
            }

            else if (operate == "/")
            {
                decimal result = num1 / num2;
                Console.WriteLine($"{result}");
            }

            else if (operate != "+" && operate != "-" && operate != "*" && operate != "/")
            {
                Console.WriteLine("Ungültiges Operationszeichen.");
            }
        }
    }
}
