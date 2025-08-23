using System;

namespace ConsoleApp1
{
    internal class Mymath
    {
        // ggT (rekursiv)
        static internal int Calc_ggT(int a, int b)
        {
            if (b == 0) return a;
            return Calc_ggT(b, a % b);
        }

        // kgV über ggT
        static internal int Calc_kgV(int a, int b)
        {
            return (a / Calc_ggT(a, b)) * b;
        }

        // Zahl einlesen (immer >0)
        static internal int ReadInt()
        {
            int x;
            while (!int.TryParse(Console.ReadLine(), out x) || x <= 0)
            {
                Console.Write("Bitte positive Zahl: ");
            }
            return x;
        }

        // Array-Funktionen
        static internal double Mean(int[] arr)
        {
            int sum = 0;
            foreach (int x in arr) sum += x;
            return (double)sum / arr.Length;
        }

        static internal int Min(int[] arr)
        {
            int m = arr[0];
            foreach (int x in arr) if (x < m) m = x;
            return m;
        }

        static internal int Max(int[] arr)
        {
            int m = arr[0];
            foreach (int x in arr) if (x > m) m = x;
            return m;
        }

        // Swap
        static internal void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}