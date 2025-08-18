using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Mymath
    {
        static internal int Add(int a, int b)
        {
            return a + b;

        }   

        static internal int Calc_ggT(int a, int b)
        {
            if (b==0)
            {
                return a;
            }
            else
            {
                return Calc_ggT(b, a % b); // rekursive Lösung für ggT
            }
        }

        static internal int Calc_kgV(int a, int b)
        {
            if (b==0)
            {
                return a;
            }
            else
            {
                return (a * b) / Calc_ggT(a, b); // rekursive Lösung für kgV
            }
        }

        static internal int ReadInt(int a)
        {
            if (a <= 0)
            {
                Console.WriteLine("Die Zahl muss größer als 0 sein.");
                return ReadInt(a);
            }
            else 
            { 
                return a;
            }
        }

    }
}
