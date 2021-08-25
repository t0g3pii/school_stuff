using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vergleich_Prozedural_vs._Objektorientierung
{
    class Person
    {
        // Attribute
        private string name;
        private string vorname;
        private string hobby;
        private string beruf;
        private int alter;
        private bool changed;

        // Konstruktor
        public Person()
        {
            this.name = "";
            this.vorname = "";
            this.alter = 0;
            changed = false;
            this.beruf = "";
            this.hobby = "";
        }
        public Person(string name, string vorname, int alter)
        {
            if (StringHasNumber(name) == false)
            {
                this.name = name;
            }
            if (StringHasNumber(vorname) == false)
            {
                this.vorname = vorname;
            }
            this.alter = alter;
            changed = false;
        }

        public Person(string name, string vorname, int alter, string beruf, string hobby)
        {
            if (StringHasNumber(name) == false)
            {
                this.name = name;
            }
            if (StringHasNumber(vorname) == false)
            {
                this.vorname = vorname;
            }
            this.alter = alter;
            changed = false;
            this.beruf = beruf;
            this.hobby = hobby;
        }

        // Eigenschaften
        public string Name
        {
            set
            {
                if (StringHasNumber(value) == false)
                {
                    name = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Der Name wurde nicht geändert. Grund: Zahl im Namen.");
                    Console.ResetColor();
                }
            }
            get
            {
                return name;
            }
        }
        public string Vorname
        {
            set
            {
                if (changed == false)
                {
                    if (StringHasNumber(value) == false)
                    {
                        vorname = value;
                        changed = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Der Name wurde erfolgreich geändert.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Der Name wurde nicht geändert. Grund: Zahl im Namen.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Der Name wurde nicht geändert. Grund: Der Vorname wurde bereits geändert.");
                    Console.ResetColor();
                }
            }
            get
            {
                return vorname;
            }
        }
        public int Alter
        {
            set
            {
                alter = Alter;
            }
            get
            {
                return alter;
            }
        }
        public string Beruf
        {
            set
            {
                beruf = value;
            }
            get
            {
                return beruf;
            }
        }
        public string Hobby
        {
            set
            {
                hobby = value;
            }
            get
            {
                return hobby;
            }
        }

        // Methoden
        public void Ausgeben()
        {
            Console.WriteLine("Name : " + name + "\nVorname: " + vorname + "\nAlter: " + alter + "\nBeruf: " + beruf + "\nHobby: " + hobby + "\n");
        }

        public bool StringHasNumber(string s)
        {
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
