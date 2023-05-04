using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozaci
{
    public class ListaVozaca
    {
        public delegate void SortDelegate(List<Vozac> vozaci);
        public SortDelegate SortListDelegate { get; set; }
        private List<Vozac> _listaVozaca;

        private static ListaVozaca _instance = null;
        public static ListaVozaca Instancez {
            get {
                if(_instance==null)
                   _instance = new ListaVozaca();
                return _instance;
            } 
        }
        public ListaVozaca() {
            _listaVozaca= new List<Vozac>();
        }
        internal List<Vozac> GetVozaci()
        {
            return _listaVozaca;    
        }
        internal void AddVozac(Vozac vozac)
        {
            _listaVozaca.Insert(0,vozac);
        }

        internal void RemoveVozac(Vozac vozac)
        {
            _listaVozaca.Remove(vozac);
        }

        internal void Clear()
        {
            _listaVozaca.Clear();
        }

        internal void SortVozaci(SortDelegate SortListDelegate)
        {

        }


    }
}
