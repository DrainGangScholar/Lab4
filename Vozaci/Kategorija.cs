using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozaci
{
    public class Kategorija
    {
        public string Ime { get; set; }
        public DateTime VaziOd { get; set; }
        public DateTime VaziDo { get; set; }
        public Kategorija(string ime, DateTime vaziOd, DateTime vaziDo)
        {
            Ime = ime;
            VaziOd = vaziOd;
            VaziDo = vaziDo;
        }
    }
}
