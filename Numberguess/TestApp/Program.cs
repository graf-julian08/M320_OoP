using System.Security.Cryptography;

namespace TestApp
{
    internal class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 200);

            // Console.WriteLine($"Die Zahl ist {random}");
            Console.WriteLine($"Type in a number between 1 and 200");
            int guess = Convert.ToInt32(Console.ReadLine());
            Class1.guessnumb(random, guess);
        }
    }
}
