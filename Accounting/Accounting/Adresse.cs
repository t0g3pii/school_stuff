using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    class Adresse
    {
        private string strasse;
        private string hausnummer;
        private string plz;
        private string ort;

        public Adresse(string strasse, string hausnummer, string plz, string ort)
        {
            this.strasse = strasse;
            this.hausnummer = hausnummer;
            this.plz = plz;
            this.ort = ort;
        }

        public string Strasse
        {
            get
            {
                return strasse;
            }
        }

        public string Hausnummer
        {
            get
            {
                return hausnummer;
            }
        }

        public string PLZ
        {
            get
            {
                return plz;
            }
        }

        public string Ort
        {
            get
            {
                return ort;
            }
        }
    }
}
