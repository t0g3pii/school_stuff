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
            Land de = new Land("Deutschland", "DE");
            Besitzer b1 = new Besitzer("Max", "Mustermann", "Straße", "0", "12345", "Musterstadt", de);
            Tankschiff tanker = new Tankschiff("Tankschiff", de, 1, 2, 3, 4, 5, 6);
            Containerschiff cont = new Containerschiff("Containerschiff", de, 1, 2, 3, 4, 5, 6);
            Sportboot sport = new Sportboot("Sportboot", 1, 2, 3, 4, 5, b1);
            Segelboot segel = new Segelboot("Segelboot", 1, 2, 3, 4, 5, b1);
        }
    }
}
