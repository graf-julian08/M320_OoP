using System;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rt = new Rectangle();

            rt.Setlaenge(5);
            rt.Setbreite(10);

            Console.WriteLine($"Das Rechteck ist {rt.Getlaenge(5)} cm lang und {rt.Getbreite(10)} cm breit.");
        }
    }
}