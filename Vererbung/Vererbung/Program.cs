using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            /** Land de = new Land("Deutschland", "DE");
            Besitzer b1 = new Besitzer("Max", "Mustermann", "Straße", "0", "12345", "Musterstadt", de);
            Tankschiff tanker = new Tankschiff("Tankschiff", de, 1, 2, 3, 4, 5, 6);
            Containerschiff cont = new Containerschiff("Containerschiff", de, 1, 2, 3, 4, 5, 6);
            Sportboot sport = new Sportboot("Sportboot", 1, 2, 3, 4, 5, b1);
            Segelboot segel = new Segelboot("Segelboot", 1, 2, 3, 4, 5, b1);
            */

            Schiff s1 = new Schiff("",0,0,0,0,0,0,new Land("",""));
        }

        abstract class Wasserfahrzeug
        {
            protected string name;
            protected int laengeInMetern;
            protected int breiteInMetern;
            protected int hoheInMetern;
            protected int tiefgangInMetern;
            protected double ladegewichtInTonnen;
            protected int leistungInKw;

            public Wasserfahrzeug(string name, int laengeInMetern, int breiteInMetern, int hoheInMetern, int tiefgangInMetern, double ladegewichtInTonnen, int leistungInKw)
            {
                this.name = name;
                this.laengeInMetern = laengeInMetern;
                this.breiteInMetern = breiteInMetern;
                this.hoheInMetern = hoheInMetern;
                this.tiefgangInMetern = tiefgangInMetern;
                this.ladegewichtInTonnen = ladegewichtInTonnen;
                this.leistungInKw = leistungInKw;
            }
        }

        class Schiff:Wasserfahrzeug
        {
            protected Land land;
            public Schiff(string name, int laengeInMetern, int breiteInMetern, int hoeheInMeter, int tiefgangInMetern, double ladegewichtInTonnen, int leistungInKw, Land land):base(name, laengeInMetern, breiteInMetern, hoeheInMeter, tiefgangInMetern, ladegewichtInTonnen, leistungInKw)
            {
                this.land = land;
            }
        }
    }
}
