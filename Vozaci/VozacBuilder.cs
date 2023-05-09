namespace Vozaci
{
    public class VozacBuilder
    {
        private string Ime;
        private string Prezime;
        private string BrVozacke;
        public DateTime DatumRodjenja;
        public string MestoIzdavanja;
        public char Pol;
        private List<Kategorija> Kategorije = new List<Kategorija>();
        private List<Zabrana> Zabrane = new List<Zabrana>();

        public VozacBuilder(string ime, string prezime, string brVozacke,DateTime datumRodjenja, string mestoIzdavanja, char pol, List<Kategorija> kategorije,List<Zabrana> zabrane)
        {
            Ime = ime;
            Prezime = prezime;
            BrVozacke = brVozacke;
            DatumRodjenja = datumRodjenja;
            MestoIzdavanja = mestoIzdavanja;
            Pol = pol;
            Kategorije = kategorije;
            Zabrane = zabrane;
        }
        public VozacBuilder SetIme(string ime)
        {
            Ime = ime;
            return this;
        }

        public VozacBuilder SetPrezime(string prezime)
        {
            Prezime = prezime;
            return this;
        }

        public VozacBuilder SetBrVozacke(string brVozacke)
        {
            BrVozacke = brVozacke;
            return this;
        }

        public VozacBuilder SetDatumRodjenja(DateTime datumRodjenja)
        {
            DatumRodjenja = datumRodjenja;
            return this;
        }

        public VozacBuilder SetMestoIzdavanja(string mestoIzdavanja)
        {
            MestoIzdavanja = mestoIzdavanja;
            return this;
        }

        public VozacBuilder SetPol(char pol)
        {
            Pol = pol;
            return this;
        }

        public VozacBuilder AddKategorija(Kategorija kategorija)
        {
            Kategorije.Add(kategorija);
            return this;
        }

        public VozacBuilder AddZabrana(Zabrana zabrana)
        {
            Zabrane.Add(zabrana);
            return this;
        }

        public Vozac Build()
        {
            return new Vozac(Ime,Prezime,BrVozacke,DatumRodjenja,MestoIzdavanja,Pol,Kategorije,Zabrane);
        }
    }
}
