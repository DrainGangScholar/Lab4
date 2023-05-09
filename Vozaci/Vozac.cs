using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string MestoIzdavanja { get; set; }
        public char Pol { get; set; }
        public List<Kategorija> PolozeneKategorije { get; set; } = new();
        public List<Zabrana> Zabrane { get; set; } = new();

        public Vozac(string ime, string prezime, string brVozacke, DateTime datumRodjenja,DateTime datumOd,DateTime datumDo, string mestoIzdavanja, char pol, List<Kategorija> polozeneKategorije, List<Zabrana> zabrane)
        {
            Ime = ime;
            Prezime = prezime;
            BrVozacke = brVozacke;
            DatumRodjenja = datumRodjenja;
            DatumOd = datumOd;
            DatumDo = datumDo;
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
        public void AddKategorija(Kategorija kategorija)
        {
            if (PolozeneKategorije.Any(k => k.Ime == kategorija.Ime))
            {
                return;
            }
            PolozeneKategorije.Add(kategorija);
        }

        public void AddKategorija(Zabrana zabrana)
        {
            if (Zabrane.Any(k => k.Ime == zabrana.Ime))
            {
                return;
            }
            Zabrane.Add(zabrana);
        }
        public List<Kategorija> GetPolozeneKategorijeImena()
        {
            return PolozeneKategorije;
        }
        public static VozacBuilder Builder()
        {
            return new VozacBuilder();
        }

    }
}
