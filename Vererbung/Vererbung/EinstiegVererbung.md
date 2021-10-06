```cs
using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("== SCHUELER ==");
		Schueler s = new Schueler("Daniel", "Düsentrieb", "IAF9000");
		s.Vorstellen();
		s.InformationenAusgeben();

		////TODO: Diese Zeilen sollen funktionieren und die gewünschte Ausgabe erzeugen
		Console.WriteLine("\n== LEHRKRAFT ==");
		Lehrkraft th = new Lehrkraft("TH", "Marcus", "Thomas");
		th.Vorstellen();				// Ausgabe: Guten Morgen, mein Name ist Herr Thomas.
		th.InformationenAusgeben();	// Ausgabe: (TH) Marcus Thomas.

		////TODO: Diese Zeilen sollen funktionieren und die gewünschte Ausgabe erzeugen
		Console.WriteLine("\n== ABTEILUNGSLEITUNG ==");
		Abteilungsleitung my = new Abteilungsleitung("MY", "Ulrich", "Meyer", "ITA");
		my.Vorstellen();				//Ausgabe: Guten Morgen, mein Name ist Herr Meyer. Ich leite die Abteilung ITA.
		my.InformationenAusgeben();		// Ausgabe: (MY) Ulrich Meyer, ITA.

		//TODO: Alle Objekte in eine Liste legen und nacheinander InformationenAusgeben().
		Console.WriteLine("\n== LISTE ==");
		List<Mensch> objList = new List<Mensch>();
		objList.Add(s);
		objList.Add(th);
		objList.Add(my);
		for(int i = 0; i < objList.Count; i++) {
			objList[i].InformationenAusgeben();			
		}
	}
}


abstract class Mensch
{
	
	protected string name;
	protected string vorname;
	
	protected Mensch(string vorname, string name)
	{
		this.vorname = vorname;
		this.name = name;
	}
	
	
	public abstract void InformationenAusgeben();
	
	public virtual void Vorstellen()
	{
		Console.WriteLine("Guten Morgen, mein Name ist " + vorname + " " + name);
	}
}


class Schueler:Mensch
{
	private string klasse;

	public Schueler(string vorname, string nachname, string klasse):base(vorname, nachname)
	{
		this.klasse = klasse;
	}

	public override void InformationenAusgeben()
	{
		Console.WriteLine(name + ", " + vorname + " - " + klasse);
	}
}

class Lehrkraft:Mensch {
	protected string kuerzel;
	
	public Lehrkraft(string kuerzel, string vorname, string nachname):base(vorname, nachname) {
		this.kuerzel = kuerzel;
	}
	
	public override void InformationenAusgeben() {
		Console.WriteLine("(" + kuerzel + ") " + vorname + " " + name);
	}
	
	//Ausgabe: Guten Morgen, mein Name ist Herr Meyer. Ich leite die Abteilung ITA.
	public override void Vorstellen() {
		Console.WriteLine("Guten Morgen, mein Name ist Herr " + name);
	}
}

class Abteilungsleitung:Lehrkraft {
	private string abteilung;
	
	public Abteilungsleitung(string kuerzel, string vorname, string nachname, string abteilung):base(kuerzel, vorname, nachname) {
		this.abteilung = abteilung;
	}
	
	// Ausgabe: (MY) Ulrich Meyer, ITA.
	public override void InformationenAusgeben() {
		Console.WriteLine("(" + kuerzel + ") " + vorname + " " + name + ", " + abteilung);
	}
	
	//Ausgabe: Guten Morgen, mein Name ist Herr Meyer. Ich leite die Abteilung ITA.
	public override void Vorstellen() {
		Console.WriteLine("Guten Morgen, mein Name ist Herr " + name + ". Ich leite die Abteilung " + abteilung + ".");
	}
	
}
```
