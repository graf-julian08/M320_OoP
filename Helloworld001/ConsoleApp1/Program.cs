namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 20;

            Console.WriteLine("Bitte geben Sie eine ganze, positive Zahl ein.");
            int a = Convert.ToInt32(Console.ReadLine());
            Mymath.ReadInt(a);
        }
    }
}
