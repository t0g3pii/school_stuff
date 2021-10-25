using System;

namespace Bankdaten
{
	class Program
	{
		static void Main(string[] args)
		{
			Rechenwerk rechenwerk = new Rechenwerk();

			Console.WriteLine("PRÜFSUMMENGENERATOR");
			Console.WriteLine("Geben Sie Ihre Abteilungs- und Betriebsnummer ein!");
			Console.WriteLine("Abteilungsnummer: ");
			int abteilungNr = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Betriebsnummer:");
			int betriebNr = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(rechenwerk.BerechnePruefsumme(abteilungNr, betriebNr));
			Console.ReadKey();


		}
	}
}
