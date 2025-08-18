namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int a = 6;
            int b = 7;
            int summe = Mymath.Add(a, b);

            Console.WriteLine($"Die Summe von {a} und {b} ist {summe}.");
        }
    }
}
