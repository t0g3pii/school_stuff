using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    class Person
    {
        private List<Adresse> adressen = new List<Adresse>();
        private DateTime geburtsdatum;
        private List<Account> konten = new List<Account>();
        private string name;
        private Person vormund;

        public Person(string name, DateTime geburtsdatum, string strasse, string hausnummer, string plz, string ort)
        {
            if(IstVolljaehrig == true) {
                this.name = name;
                this.geburtsdatum = geburtsdatum;
                adressen.Add(new Adresse(strasse, hausnummer, plz, ort));
            } else
            {
                throw new Exception("Die Person ist Minderjährig. Bitte gebe einen Vormund an.");
            }
            
        }
        public Person(string name, DateTime geburtsdatum, string strasse, string hausnummer, string plz, string ort, Person vormund)
        {
            this.name = name;
            this.geburtsdatum = geburtsdatum;
            adressen.Add(new Adresse(strasse, hausnummer, plz, ort));
            this.vormund = vormund;
        }

        public bool IstVolljaehrig
        {
            get
            {
                if((DateTime.Now.Year - geburtsdatum.Year) < 18)
                {
                    return false;
                } else
                {
                    return true;
                }
            }
        }

        public List<Account> Konten
        {
            get
            {
                return konten;
            }
        }

        public Person Vormund
        {
            get
            {
                return vormund;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string AktuelleAdresseAusgeben()
        {
            Adresse temp = adressen.Last();
            return temp.Strasse + " " + temp.Hausnummer + " " + temp.PLZ + " " + temp.Ort;
        }

        public List<Adresse> AlleAdressenAusgeben()
        {
            return adressen;
        }

        public decimal GuthabenInsgesamtAusgeben()
        {
            return 0; // Not Implemented
        }

        public void NeueAdresseEingeben(string strasse, string hausnummer, string plz, string ort)
        {
            adressen.Add(new Adresse(strasse, hausnummer, plz, ort));
        }

        public void NeuesKontoEroeffnen(decimal guthaben)
        {
            if(IstVolljaehrig)
            {
                // konten.Add(new Account());
            } else {
                // user ist nicht volljärig
                
            }
        }

    }
}
