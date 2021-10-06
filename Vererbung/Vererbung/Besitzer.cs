namespace Vererbung
{
	class Besitzer
	{
		private string vorname;
		private string nachname;
		private string strasse;
		private string hausnummer;
		private string plz;
		private string ort;
		private Land land;

		public Besitzer(string vorname, string nachname, string strasse, string hausnummer, string plz, string ort, Land land)
		{
			this.vorname = vorname;
			this.nachname = nachname;
			this.strasse = strasse;
			this.hausnummer = hausnummer;
			this.plz = plz;
			this.ort = ort;
			this.land = land;
		}

		public string Vorname
		{
			get
			{
				return vorname;
			}
		}
		public string Nachname
		{
			get
			{
				return nachname;
			}
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
		public string Plz
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
		public Land Land
		{
			get
			{
				return land;
			}
		}
	}
}