using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozaci
{
    public class Zabrana
    {
        public string Ime { get; set; }
        public DateTime VaziOd { get; set; }
        public DateTime VaziDo { get; set; }
        public Zabrana(string ime, DateTime vaziOd, DateTime vaziDo)
        {
            Ime = ime;
            VaziOd = vaziOd;
            VaziDo = vaziDo;
        }
    }
}
