using System;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangular rec1 = new rectangular();

            // Attribute setzen
            rec1.Color = "Red";
            rec1.Punkt = (5, 5);
            rec1.Length = 8;
            rec1.Width = 3;

            // Methoden testen
            Console.WriteLine($"Farbe: {rec1.Color}");
            Console.WriteLine($"Startpunkt: ({rec1.Punkt.x}, {rec1.Punkt.y})");
            Console.WriteLine($"Fläche: {rec1.CalcFläche()}");

            var neuerPunkt = rec1.VerschiebeRec(2, 0);
            Console.WriteLine($"Nach Verschiebung: ({neuerPunkt.x}, {neuerPunkt.y})");

            var skaliert1 = rec1.SkaliereRec(1.0);
            Console.WriteLine($"Skaliert (f=1.0): Länge={skaliert1.length}, Breite={skaliert1.width}");

            var skaliert2 = rec1.SkaliereRec(2.0);
            Console.WriteLine($"Skaliert (f=2.0): Länge={skaliert2.length}, Breite={skaliert2.width}");

            var skaliert3 = rec1.SkaliereRec(0.5, 1.0);
            Console.WriteLine($"Skaliert (fx=0.5, fy=1.0): Länge={skaliert3.length}, Breite={skaliert3.width}");

            Console.WriteLine($"Winkelsumme: {rec1.BerechneWinkel()}");

            Console.WriteLine("Zeichnung:");
            rec1.zeichne();
        }
    }
}