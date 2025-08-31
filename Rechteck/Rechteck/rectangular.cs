using System;

namespace Shapes
{
    internal class rectangular
    {
        // Attribute privat
        private int length;
        private int width;
        private string color;
        private (int x, int y) punkt;
        private readonly int winkelsumme = 360;

        // Properties (öffentliche Schnittstelle)
        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public (int x, int y) Punkt
        {
            get { return punkt; }
            set { punkt = value; }
        }

        public int Winkelsumme // nur lesen, da readonly
        {
            get { return winkelsumme; }
        }

        // Methoden
        public double CalcFläche()
        {
            return length * width;
        }

        public (int x, int y) VerschiebeRec(int dx, int dy)
        {
            punkt = (punkt.x + dx, punkt.y + dy);
            return punkt;
        }

        public (int length, int width) SkaliereRec(double f)
        {
            int newLength = Math.Max(1, (int)Math.Round(length * f));
            int newWidth = Math.Max(1, (int)Math.Round(width * f));
            length = newLength;
            width = newWidth;
            return (length, width);
        }

        public (int length, int width) SkaliereRec(double fx, double fy)
        {
            int newLength = Math.Max(1, (int)Math.Round(length * fx));
            int newWidth = Math.Max(1, (int)Math.Round(width * fy));
            length = newLength;
            width = newWidth;
            return (length, width);
        }

        public int BerechneWinkel()
        {
            return Winkelsumme;
        }

        // Zeichnet nur den Rand des Rechtecks in der Konsole mit 'X'
        public void ZeichneRec()
        {
            if (length <= 0 || width <= 0) return;

            for (int row = 0; row < width; row++)
            {
                if (row == 0 || row == width - 1)
                {
                    for (int col = 0; col < length; col++)
                        Console.Write("X");
                    Console.WriteLine();
                }
                else
                {
                    if (length == 1)
                    {
                        Console.WriteLine("X");
                    }
                    else
                    {
                        Console.Write("X");
                        for (int col = 0; col < length - 2; col++)
                            Console.Write(" ");
                        Console.WriteLine("X");
                    }
                }
            }
        }
        public void zeichne()
        {
            // Sicherheitscheck: Wenn Länge oder Breite ungültig sind, abbrechen
            if (length <= 0 || width <= 0) return;

            // Schleife über alle Zeilen des Rechtecks
            for (int row = 0; row < width; row++)
            {
                // Erste und letzte Zeile: kompletter Rand aus 'X'
                if (row == 0 || row == width - 1)
                {
                    for (int col = 0; col < length; col++)
                        Console.Write("X"); // Horizontale Linie
                    Console.WriteLine();   // Zeilenumbruch
                }
                else
                {
                    // Spezialfall: Länge = 1 → nur ein 'X' pro Zeile
                    if (length == 1)
                    {
                        Console.WriteLine("X");
                    }
                    else
                    {
                        Console.Write("X"); // Linker Rand
                        for (int col = 0; col < length - 2; col++)
                            Console.Write(" "); // Innenraum (leer)
                        Console.WriteLine("X"); // Rechter Rand + Zeilenumbruch
                    }
                }
            }
        }
    }
}