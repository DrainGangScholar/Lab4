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
        public DateTime DatumRodjenja { get; set; }
        public string MestoIzdavanja { get; set; }
        public char Pol { get; set; }
        public List<Kategorija> PolozeneKategorije { get; set; } = new();
        public List<Zabrana> Zabrane { get; set; } = new();

        public Vozac(string ime, string prezime, string brVozacke, DateTime datumRodjenja, string mestoIzdavanja, char pol, List<Kategorija> polozeneKategorije, List<Zabrana> zabrane)
        {
            Ime = ime;
            Prezime = prezime;
            BrVozacke = brVozacke;
            DatumRodjenja = datumRodjenja;
            MestoIzdavanja = mestoIzdavanja;
            Pol = pol;
            PolozeneKategorije = polozeneKategorije;
            Zabrane = zabrane;
        }

        public Vozac()
        {
        }

        public string GetIme() { return Ime; }
        public string GetPrezime() { return Prezime; }
        public string GetBrVozacke() { return BrVozacke; }
        public DateTime GetDatumRodjenja() { return DatumRodjenja; }
        public string GetMestoIzdavanja() { return MestoIzdavanja; }
        public char GetPol() { return Pol; }
        public void SetIme(string ime) {  Ime=ime; }
        public void SetPrezime(string prezime) {  Prezime=prezime; }
        public void SetBrVozacke(string brVozacke) { BrVozacke = brVozacke; }
        public void SetDatumRodjenja(DateTime datumRodjenja) { DatumRodjenja = datumRodjenja; }
        public void SetMestoIzdavanja(string mestoIzdavanja) { MestoIzdavanja = mestoIzdavanja; }
        public void SetPol(char pol) {  Pol=pol; }
        public void AddKategorija(Kategorija kategorija){PolozeneKategorije.Add(kategorija);}
        public void AddZabrana(Zabrana zabrana){Zabrane.Add(zabrana);}
        public static VozacBuilder Builder()
        {
            return new VozacBuilder();
        }

    }
}
