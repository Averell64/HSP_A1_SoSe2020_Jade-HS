using System;

namespace Sprint1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variablen
            #region
            int a;
            string auswahl;
            double Laenge, Breite, Durchmesser;
            string ff, s, tt;

            double pi = Math.PI;
            #endregion
            //Abfrage von Profilen  
            #region          
            Console.WriteLine("Berechnung von Profilen");
            Console.WriteLine("Wähle eine Geometrie");
            Console.WriteLine("1:Rechteck");
            Console.WriteLine("2:Kreisprofil");
            Console.WriteLine("3:Rohrprofil");
            Console.WriteLine("4:T-Profil");
            Console.WriteLine("5:Programm beenden");
            Console.WriteLine("Bitte wähle");
            auswahl = Console.ReadLine();
            a = Convert.ToInt32(auswahl);
            #endregion

            //Rechteckprofil
            if (a == 1)
            #region
            {
                Console.WriteLine("Geben Sie bitte die Laenge des Rechteckprofils ein [mm]:");
                Laenge = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Geben Sie bitte die Breite des Rechteckprofils ein [mm]:");
                Breite = Convert.ToDouble(Console.ReadLine());

                Console.Clear();

                ff = FlaecheRechteck(Laenge, Breite);
                Console.WriteLine("A = " + ff + "mm^2");

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
            #endregion
            //Kreisprofil
            else if (a == 2)
            #region
            {
                Console.WriteLine("Geben Sie bitte den Durchmesser ein [mm]");

                Durchmesser = Convert.ToDouble(Console.ReadLine());

                Console.Clear();

                ff = FlaecheKreis(Durchmesser, pi);
                Console.WriteLine("A = " + ff + "mm^2");

                s = SchPunktKreis(Durchmesser);
                string[] sxy = s.Split('/');
                foreach (string Schw in sxy)
                {
                    Console.WriteLine(Schw.ToString());
                }

                tt = TraegMomK(Durchmesser, pi);
                string[] txy = s.Split('/');

                Console.WriteLine(tt);






            }

            #endregion
        }


        //Verweise
        #region

        static string FlaecheRechteck(double Laenge, double Breite)
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
            double ix = (Laenge * Math.Pow(Breite, 3)) / (12);
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
        static string FlaecheKreis(double Durchmesser, double pi)
        {

            string ff = Convert.ToString((Durchmesser / 2) * (Durchmesser / 2) * pi);
            return ff;
        }

        static string SchPunktKreis(double Durchmesser)
        {
            double sx = Durchmesser / 2, sy = 0;
            string s = "Schwerpunkt in X-Richtung = " + Convert.ToString(sx) + "mm" + "/Schwerpunkt in Y-Richtung = " + Convert.ToString(sy) + "mm";
            return s;
        }

        static string TraegMomK(double Durchmesser, double pi)
        {
            //Axiales Flaechenmoment 2.Grades ( Biegung)
            double ii = ((Durchmesser * Durchmesser * Durchmesser * Durchmesser * pi) / 64);
            //Axiales Widerstandmoment (Biegung)
            double ww = ((Durchmesser * Durchmesser * Durchmesser * pi) / 32);
            // Ausgabe 
            string tt = "/Axiales Flächenmoment 2. Grades = " + Convert.ToString(ii) + "mm^4"
                + "/Axiales Widerstandsmoment in X-Richtung = " + Convert.ToString(ww) + "mm^3";
            return tt;
        }

        #endregion










    }
}

