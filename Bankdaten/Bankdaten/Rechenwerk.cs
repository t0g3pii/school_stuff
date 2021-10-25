using System;

namespace Bankdaten
{
	public class Rechenwerk
	{
		/// <summary>
		/// Berechnet eine Prüfsumme aus Eingabewerten.
		/// </summary>
		/// <param name="a">Abteilungsnummer</param>
		/// <param name="b">Betriebsnummer</param>
		/// <returns></returns>
		public int BerechnePruefsumme(int a, int b)
		{
			Console.WriteLine("Block 1");
			int x;
			int y;
			int z;

			if (a < b)
			{
				Console.WriteLine("Block 2");
				x = b;
				z = 1;
			}
			else
			{
				Console.WriteLine("Block 3");
				x = a;
				z = 0;
			}

			if ((a + b) < 10)
			{
				Console.WriteLine("Block 4");
				y = x + b / z;
			}
			else
			{
				Console.WriteLine("Block 5");
				y = x + a;
				if ((a + b) == 7)
				{
					Console.WriteLine("Block 6");
					y++;
				}
			}
			Console.WriteLine("Block 7");
			return x + y + z;
		}

	}
}
