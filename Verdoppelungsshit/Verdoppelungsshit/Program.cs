+﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recheckprofil
{
    class Program
    {
        static void Main(string[] args)
        {



            double a, b;
            bool schleife;


            Console.WriteLine("Kantenlänge a (Breite) in mm eingeben:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kantenlänge b (Höhe) in mm eingeben:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Clear();


            do
            {
                schleife = true;
                Console.WriteLine("Was möchten Sie berechen?");
                Console.WriteLine("<1> Fläche");
                Console.WriteLine("<2> Flächenschwerpunkt");
                Console.WriteLine("<3> Flächenträgheitsmoment");
                Console.WriteLine("<4> Parameter zurücksetzen");

                int x = Convert.ToInt32(Console.ReadLine());

                if (x == 1)
                {
                    Flaeche(a, b);
                }

                else if (x == 2)
                {
                    Flaechenschwerpunkt(a, b);
                }

                else if (x == 3)
                {
                    Flaechentraeg(a, b);
                }
                else if (x == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Kantenlänge a (Breite) in mm eingeben:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Kantenlänge b (Höhe) in mm eingeben:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();

                }

            }
            while (schleife == true);


        }
        static void Flaeche(double a, double b)
        {
            Console.Clear();
            double A;
            A = a * b;
            Console.WriteLine("Die Fläche des Rechteckprofils beträgt:  " + A + "  mm^2");
            Console.WriteLine("Press any key to get back");
            Console.ReadKey();
            Console.Clear();
        }

        static void Flaechenschwerpunkt(double a, double b)
        {
            Console.Clear();
            double Xs, Ys;

            Xs = a / 2;
            Ys = b / 2;
            Console.WriteLine("Der Flächenschwerpunkt des Rechteckprofils liegt bei: ");
            Console.WriteLine("Xs: " + Xs + "mm");
            Console.WriteLine("Ys: " + Ys + "mm");
            Console.WriteLine("Press any key to get back");
            Console.ReadKey();
            Console.Clear();
        }
        static void Flaechentraeg(double a, double b)
        {
            Console.Clear();
            double Ix, Iy;
            Ix = (a * (Math.Pow(b, 3))) / 12;
            Iy = (b * (Math.Pow(a, 3))) / 12;
            Console.WriteLine("Die Flächenträgheitsmomente betragen: ");
            Console.WriteLine("Ix: " + Ix + "mm^4");
            Console.WriteLine("Iy: " + Iy + "mm^4");
            Console.WriteLine("Press any key to get back");
            Console.ReadKey();
            Console.Clear();

        }

    }
}

