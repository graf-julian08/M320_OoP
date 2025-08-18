namespace Calculator
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Gib die erste Zahl ein:");
            decimal num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib die zweite Zahl ein:");
            decimal num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib die gewünschte Operation ein (+, -, *, /):");
            string operation = Console.ReadLine();
            
            Calc.operatenum(num1, num2, operation);
        }
    }
}
