using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EinstiegVererbung.Schiff
{
	class Land
	{
		private string name;
		private string kuerzel;

		public Land(string name, string kuerzel)
		{
			this.name = name;
			this.kuerzel = kuerzel;
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
		public string Kuerzel
		{
			get
			{
				return kuerzel;
			}

			set
			{
				kuerzel = value;
			}
		}
	}
}
