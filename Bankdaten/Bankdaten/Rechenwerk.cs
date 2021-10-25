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
			int x;
			int y;
			int z;

			if (a < b)
			{
				x = b;
				z = 1;
			}
			else
			{
				x = a;
				z = 0;
			}

			if ((a + b) < 10)
			{
				y = x + b / z;
			}
			else
			{
				y = x + a;
				if ((a + b) == 7)
				{
					y++;
				}
			}

			return x + y + z;
		}

	}
}
