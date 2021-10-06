namespace EinstiegVererbung.Schiff
{
	class Containerschiff
	{
		private string name;
		private Land land;
		private int laengeInMetern;
		private int breiteInMetern;
		private int hoheInMetern;
		private int tiefgangInMetern;
		private int anzahlContainer;
		private int leistungInKw;

		public Containerschiff(string name, Land land, int laengeInMetern, int breiteInMetern, int hoheInMetern, int tiefgangInMetern, int anzahlContainer, int leistungInKw)
		{
			this.name = name;
			this.land = land;
			this.laengeInMetern = laengeInMetern;
			this.breiteInMetern = breiteInMetern;
			this.hoheInMetern = hoheInMetern;
			this.tiefgangInMetern = tiefgangInMetern;
			this.anzahlContainer = anzahlContainer;
			this.leistungInKw = leistungInKw;
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

		public Land Land
		{
			get
			{
				return land;
			}

			set
			{
				land = value;
			}
		}
		public int LaengeInMetern
		{
			get
			{
				return laengeInMetern;
			}

			set
			{
				laengeInMetern = value;
			}
		}
		public int BreiteInMetern
		{
			get
			{
				return breiteInMetern;
			}

			set
			{
				breiteInMetern = value;
			}
		}
		public int HoheInMetern
		{
			get
			{
				return hoheInMetern;
			}

			set
			{
				hoheInMetern = value;
			}
		}
		public int TiefgangInMetern
		{
			get
			{
				return tiefgangInMetern;
			}

			set
			{
				tiefgangInMetern = value;
			}
		}
		public int AnzahlContainer
		{
			get
			{
				return anzahlContainer;
			}

			set
			{
				anzahlContainer = value;
			}
		}
		public int LeistungInKw
		{
			get
			{
				return leistungInKw;
			}

			set
			{
				leistungInKw = value;
			}
		}
	}
}
