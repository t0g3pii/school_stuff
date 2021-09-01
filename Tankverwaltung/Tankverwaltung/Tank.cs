using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tankverwaltung
{
    class Tank
    {
        private static int anzahlTank = 0;
        private int nummer;
        private double hoehe;
        private double radius;
        private double volumen;
        private double fuellstand;

        public Tank(double hoehe, double radius)
        {
            if (hoehe < 0 || radius < 0) throw new Exception();
            if (hoehe > 10 || radius > 3) throw new Exception();
            this.hoehe = hoehe;
            this.radius = radius;
            volumen = Math.Round((radius * radius) * Math.PI * hoehe);
            fuellstand = 0;
            anzahlTank++;
            nummer = anzahlTank;

            // DEBUG // GEHÖRT HIER NIEMALS HIN
            Console.WriteLine("Tank mit der ID " + nummer + " wurde erstellt");
        }

        public double Fuellstand
        {
            get
            {
                return fuellstand;
            }
        }

        public double Volumen
        {
            get
            {
                return (radius * radius) * Math.PI * hoehe;
            }
        }

        public void Befuellen(double ml)
        {
            if (ml < 0) throw new Exception();
            if((fuellstand + ml) > volumen) throw new Exception();
            fuellstand = fuellstand + ml;
        }

        public void Entleeren(double ml)
        {
            if (ml < 0) throw new Exception();
            if ((fuellstand - ml) < 0) throw new Exception();
            fuellstand = fuellstand - ml;
        }

        public void Ausgeben()
        {
            Console.WriteLine("[DEBUG]"
                            + "\nTanknummer: " + nummer 
                            + "\nHöhe in Meter: " + hoehe 
                            + "\nRadius in Meter: " + radius 
                            + "\nVolumen in Liter: " + volumen
                            + "\nFüllstand in Liter: " + fuellstand);
        }
    }
}
