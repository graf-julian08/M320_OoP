using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repetition
{
    using System;

    public class array
    {
        static public void ArrayCalc()
        {
            int[] ar = { 200, 450, 700, 175, 250 };

            int summe = 0;
            foreach (int wert in ar)
            {
                summe += wert;
            }
            Console.WriteLine("Summe: " + summe);
        }
    }
}
