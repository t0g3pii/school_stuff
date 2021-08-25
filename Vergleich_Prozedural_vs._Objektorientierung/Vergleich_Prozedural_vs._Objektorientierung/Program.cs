using System;

namespace Vergleich_Prozedural_vs._Objektorientierung
{
    class Program
    {

        static void Main(string[] args)
        {
            // Prozedurale Personen anlegen
            string PP1_Name = "Müller";
            string PP1_Vorname = "Meyer";
            int PP1_Alter = 1;
            string PP1_Hobby = "Hobby";
            string PP1_Beruf = "Beruf";
            bool PP1_changed = false;

            string PP2_Name = "Mustermann";
            string PP2_Vorname = "Max";
            int PP2_Alter = 2;
            string PP2_Hobby = "Hobby";
            string PP2_Beruf = "Beruf";
            bool PP2_changed = false;

            string PP3_Name = "Beispiel";
            string PP3_Vorname = "OhneZahl";
            int PP3_Alter = 3;
            string PP3_Hobby = "Hobby";
            string PP3_Beruf = "Beruf";
            bool PP3_changed = false;

            // Objektorientierte Personen Anlegen
            Person OP1 = new Person("Müller", "Meyer", 1, "Beruf", "Hobby");
            Person OP2 = new Person("Mustermann", "Max", 2, "Beruf", "Hobby");
            Person OP3 = new Person("Beispiel", "OhneZahl", 3, "Beruf", "Hobby");

            // Alle Personen Ausgeben
            Console.WriteLine("[Prozedural Ausgabe]");
            Console.WriteLine("Name : " + PP1_Name + "\nVorname: " + PP1_Vorname + "\nAlter: " + PP1_Alter + "\nBeruf: " + PP1_Beruf + "\nHobby: " + PP1_Hobby + "\n");
            Console.WriteLine("Name : " + PP2_Name + "\nVorname: " + PP2_Vorname + "\nAlter: " + PP2_Alter + "\nBeruf: " + PP2_Beruf + "\nHobby: " + PP2_Hobby + "\n");
            Console.WriteLine("Name : " + PP3_Name + "\nVorname: " + PP3_Vorname + "\nAlter: " + PP3_Alter + "\nBeruf: " + PP3_Beruf + "\nHobby: " + PP3_Hobby + "\n");
            Console.WriteLine("\n\n[Objektorientiert Ausgabe]");
            OP1.Ausgeben();
            OP2.Ausgeben();
            OP3.Ausgeben();

            // Aufgabe 3a - Prozedural
            Console.WriteLine("[Zahl-Test (Prozedural)] Bitte geben sie einen neuen Vornamen für den Prozeduralen 'Meyer Müller'");
            string tempVorname = Console.ReadLine();
            if (OP1.StringHasNumber(tempVorname) == false)
            {
                PP1_Vorname = tempVorname;
                PP1_changed = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Der Name wurde erfolgreich geändert.");
                Console.ResetColor();
                Console.WriteLine("Name : " + PP1_Name + "\nVorname: " + PP1_Vorname + "\nAlter: " + PP1_Alter + "\nBeruf: " + PP1_Beruf + "\nHobby: " + PP1_Hobby + "\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Der Name wurde nicht geändert. Grund: Zahl im Namen.");
                Console.ResetColor();
            }
            Console.WriteLine("");
            // Aufgabe 3b - Prozedural
            Console.WriteLine("[Zweimal ändern Test (Prozedural)] - Bitte geben sie einen neuen Vornamen für den Prozeduralen 'Meyer Müller'");
            string tempVorname2 = Console.ReadLine();
            if (OP1.StringHasNumber(tempVorname) == false)
            {
                if (PP1_changed == false)
                {
                    PP1_Vorname = tempVorname;
                    PP1_changed = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Der Name wurde erfolgreich geändert.");
                    Console.ResetColor();
                    Console.WriteLine("Name : " + PP1_Name + "\nVorname: " + PP1_Vorname + "\nAlter: " + PP1_Alter + "\nBeruf: " + PP1_Beruf + "\nHobby: " + PP1_Hobby + "\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Der Name wurde nicht geändert. Grund: Der Vorname wurde bereits geändert.");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Der Name wurde nicht geändert. Grund: Zahl im Namen.");
                Console.ResetColor();
            }

            // Aufgabe 3a
            Console.WriteLine("[Zahl-Test (Objektorientiert)] Bitte geben sie einen neuen Vornamen für das Objekt 'Meyer Müller'");
            OP1.Vorname = Console.ReadLine();
            OP1.Ausgeben();
            Console.WriteLine("");
            // Aufgabe 3b - Prozedural
            Console.WriteLine("[Zweimal ändern Test (Objektorientiert)] - Bitte geben sie einen neuen Vornamen für das Objekt 'Meyer Müller'");
            OP1.Vorname = Console.ReadLine();
            OP1.Ausgeben();
            Console.ReadLine();
        }
    }
}
