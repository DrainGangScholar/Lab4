using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Vozaci.Delegati;

namespace Vozaci
{
    public class ListaVozaca
    {
        private List<Vozac> _listaVozaca;

        private static ListaVozaca _instance = null;
        public static ListaVozaca Instance {
            get {
                if(_instance==null)
                   _instance = new ListaVozaca();
                return _instance;
            } 
        }
        public ListaVozaca() {
            _listaVozaca= new List<Vozac>();
        }
        public List<Vozac> Vozaci
        {
            get { return _listaVozaca; }
        }
        public void AddVozac(Vozac vozac)
        {
            _listaVozaca.Insert(0,vozac);
        }

        public void RemoveVozac(Vozac vozac)
        {
            _listaVozaca.Remove(vozac);
        }

        public void Clear()
        {
            _listaVozaca.Clear();
        }

        public void SortVozaci(Kriterijum kriterijum)
        {
            _listaVozaca.Sort((vozac1, vozac2) => kriterijum(vozac1).CompareTo(kriterijum(vozac2)));
        }


    }
}
