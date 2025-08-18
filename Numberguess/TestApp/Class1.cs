using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    internal class Class1
    {
        static internal void guessnumb(int random, int guess)
        {
            if (random == guess)
            {
                Console.WriteLine("You guessed the number!");
            }
            else if (random > guess)
            { 
                Console.WriteLine("The number is higher than your guess, try again.");
                int newguess = Convert.ToInt32(Console.ReadLine());
                guessnumb(random, newguess);
            }
            else if (random < guess)
            {
                Console.WriteLine("The number is lower than your guess, try again.");
                int newguess = Convert.ToInt32(Console.ReadLine());
                guessnumb(random, newguess);
            }
        }
    }
}
