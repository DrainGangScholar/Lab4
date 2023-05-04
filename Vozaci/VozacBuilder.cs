namespace Vozaci
{
    public class VozacBuilder
    {
        private string Ime;
        private string Prezime;
        private string BrVozacke;
        public VozacBuilder(string ime, string prezime, string brVozacke)
        {
            Ime = ime;
            Prezime = prezime;
            BrVozacke = brVozacke;
        }
        public VozacBuilder()
        {
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
            BrVozacke= brVozacke;
            return this;
        }
        public Vozac Buil()
        {
            return new Vozac(Ime, Prezime, BrVozacke);
        }
    }
}