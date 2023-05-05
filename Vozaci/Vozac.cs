using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozaci
{
    public class Vozac
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrVozacke { get; set; }

        public Vozac(string ime, string prezime, string brVozacke)
        {
            Ime = ime;
            Prezime = prezime;
            BrVozacke = brVozacke;
        }

        public Vozac()
        {
        }

        public string GetIme() { return Ime; }
        public string GetPrezime() { return Prezime; }
        public string GetBrVozacke() { return BrVozacke; }
        public void SetIme(string ime) {  Ime=ime; }
        public void SetPrezime(string prezime) {  Prezime=prezime; }
        public void SetBrVozacke(string brVozacke) {  BrVozacke=brVozacke; }

        public static VozacBuilder Builder()
        {
            return new VozacBuilder();
        }

    }
}
