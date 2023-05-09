namespace Vozaci
{
    public class VozacBuilder
    {
        private static VozacBuilder instance = null;

        private string Ime;
        private string Prezime;
        private string BrVozacke;
        public DateTime DatumRodjenja;
        public DateTime DatumOd;
        public DateTime DatumDo;
        public string MestoIzdavanja;
        public char Pol;
        private List<Kategorija> Kategorije = new List<Kategorija>();
        private List<Zabrana> Zabrane = new List<Zabrana>();
        public string ImagePath;

        public VozacBuilder()
        {

        }

        public static VozacBuilder Instance()
        {
            if (instance == null)
            {
                instance = new VozacBuilder();
            }
            return instance;
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
        public VozacBuilder SetDatumOd(DateTime datumOd)
        {
            DatumOd=datumOd;
            return this;
        }
        public VozacBuilder SetDatumDo(DateTime datumDo)
        {
            DatumDo=datumDo;
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
        public VozacBuilder SetImagePath(string imagePath)
        {
            ImagePath = imagePath;
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
        public List<Kategorija> GetKategorije()
        {
            return Kategorije;
        }
        public Vozac Build()
        {
            return new Vozac(Ime, Prezime, BrVozacke, DatumRodjenja,DatumOd,DatumDo, MestoIzdavanja, Pol, Kategorije, Zabrane,ImagePath);
        }
    }
}
