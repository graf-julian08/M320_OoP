using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_AufgabeM320
{
    internal class Calculator
    {
        public static void math(string operation, int zahl1, int zahl2)
        {
            if (operation == "+")
            {
                int ergebnis = zahl1 + zahl2;
                Console.WriteLine(ergebnis);
            }
            else if (operation == "-")
            {
                int ergebnis = zahl1 - zahl2;
                Console.WriteLine(ergebnis);
            }
            else if (operation == "*")
            {
                int ergebnis = zahl1 * zahl2;
                Console.WriteLine(ergebnis);
            }
            else if (operation == "/")
            {
                int ergebnis = zahl1 / zahl2;
                Console.WriteLine(ergebnis);
            }
            else
            {
                Console.WriteLine("Ungültige Operation");
            }
        }
    }
}
