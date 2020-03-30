using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppenarbeit_Test_1
{
    class Program
    {
        static void Main()
        {
            double Laenge, Breite;
            string ff, s, tt;
            
            Console.WriteLine("Geben Sie bitte die Laenge des Rechteckprofils ein [mm]:");
            Laenge = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben Sie bitte die Breite des Rechteckprofils ein [mm]:");
            Breite = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            ff = Flaeche(Laenge, Breite);
            Console.WriteLine("A = " + ff+"mm^2");

            s = SchPunkt(Laenge, Breite);
            string[] sxy = s.Split('/');
            foreach (string Schw in sxy)
            {
                Console.WriteLine(Schw.ToString());
            }

            tt = TraegMom(Laenge, Breite);
            string[] ttxy = tt.Split('/');
            foreach (string Träg in ttxy)
            {
                Console.WriteLine(Träg.ToString());
            }
            Console.ReadKey();
        }

        static string Flaeche(double Laenge, double Breite)
        {
            string ff = Convert.ToString(Laenge * Breite);
            return ff;
        }

        static string SchPunkt(double Laenge, double Breite)
        {
            double sx = Laenge / 2, sy = Breite / 2;
            string s = "Schwerpunkt in X-Richtung = " + Convert.ToString(sx) + "mm" + "/Schwerpunkt in Y-Richtung = " + Convert.ToString(sy) + "mm";
            return s;
        }

        static string TraegMom(double Laenge, double Breite)
        {
            //Axiales Flaechenmoment 2. Grades (Biegung)
            double ix = (Laenge * Math.Pow(Breite, 3))/(12);
            double iy = (Breite * Math.Pow(Laenge, 3)) / (12);

            //Axiales Widerstandsmoment (Biegung)
            double wx = (Laenge * Math.Pow(Breite, 2)) / (6);
            double wy = (Breite * Math.Pow(Laenge, 2)) / (6);

            //Flaechenmoment 2. Grades (Torsion)

            //Ausgabe
            string tt = "Axiales Flächenmoment 2. Grades in X-Richtung = " + Convert.ToString(ix) + "mm^4"
                + "/Axiales Flächenmoment 2. Grades in Y-Richtung = " + Convert.ToString(iy) + "mm^4"
                + "/Axiales Widerstandsmoment in X-Richtung = " + Convert.ToString(wx) + "mm^3"
                + "/Axiales Wiederstandsmoment in Y-Richtung = " + Convert.ToString(wy) + "mm^3";
            return tt;
        }
    }
}
