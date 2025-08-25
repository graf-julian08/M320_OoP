namespace Calculator_AufgabeM320
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie die erste Zahl ein:");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben Sie die zweite Zahl ein:");
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben Sie die Operationszeichen ein (+, -, *, /):");
            string operation = Console.ReadLine();
            Calculator.math(operation, zahl1, zahl2);
        }
    }
}
