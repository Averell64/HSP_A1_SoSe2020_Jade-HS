using System;

namespace HSPSprint1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variablen
            Double LaengeA;
            Double BreiteB;
            Double Flaeche;
            Double xs;
            Double ys;
            Double Flaechenschwerpunkt;
            Double Ix;
            Double Iy;
            Double Tiefe;


            //Eingabe Kantenlängen


            Console.WriteLine("Eingabe Laenge A in mm");
            LaengeA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Eingabe Breite B in mm");
            BreiteB = Convert.ToDouble(Console.ReadLine());

            //Berechnung Flaeche

            Flaeche = LaengeA * BreiteB;
            Console.WriteLine("Fläche in mm^2:" + Flaeche);

            // Berechnung Flächenschwerpunkt

            ys = BreiteB / 2;
            xs = LaengeA / 2;
            Console.WriteLine("Hinweis: Koordinatenurspung an Außenkante des Profils gewählt");
            Console.WriteLine("Schwerpunktskoordinate in x Richtung in mm:" + xs);
            Console.WriteLine("Schwerpunktskoordinate in y Richtung in mm:" + ys);








        }
    }
}
