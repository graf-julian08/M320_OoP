using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool weiter = true;
            while (weiter)
            {
                Console.WriteLine("1=ggT, 2=kgV, 3=Array, 4=Swap, 0=Ende");
                string eingabe = Console.ReadLine();

                if (eingabe == "1")
                {
                    Console.Write("Zahl a: ");
                    int a = Mymath.ReadInt();
                    Console.Write("Zahl b: ");
                    int b = Mymath.ReadInt();
                    Console.WriteLine($"ggT von {a} und {b} ist {Mymath.Calc_ggT(a, b)}");
                }
                else if (eingabe == "2")
                {
                    Console.Write("Zahl a: ");
                    int a = Mymath.ReadInt();
                    Console.Write("Zahl b: ");
                    int b = Mymath.ReadInt();
                    Console.WriteLine($"kgV von {a} und {b} ist {Mymath.Calc_kgV(a, b)}");
                }
                else if (eingabe == "3")
                {
                    Console.Write("Wie viele Zahlen? ");
                    int n = Mymath.ReadInt();
                    int[] arr = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Wert {i + 1}: ");
                        arr[i] = Mymath.ReadInt();
                    }
                    Console.WriteLine($"Mittelwert: {Mymath.Mean(arr)}");
                    Console.WriteLine($"Kleinster Wert: {Mymath.Min(arr)}");
                    Console.WriteLine($"Groesster Wert: {Mymath.Max(arr)}");
                }
                else if (eingabe == "4")
                {
                    Console.Write("a: ");
                    int a = Mymath.ReadInt();
                    Console.Write("b: ");
                    int b = Mymath.ReadInt();
                    Mymath.Swap(ref a, ref b);
                    Console.WriteLine($"Getauscht: a={a}, b={b}");
                }
                else if (eingabe == "0")
                {
                    weiter = false;
                }
            }
        }
    }
}