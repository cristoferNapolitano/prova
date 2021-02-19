using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bookmaker
{
    public class Corsa
    {
        public Corsa(List<Partecipante> l, Partecipante v = null)
        {
            ListaPartecipanti = l;
            Vincitore = v;
        }

        private List<Partecipante> _listaPartecipanti;
        public List<Partecipante> ListaPartecipanti
        {
            get
            {
                return _listaPartecipanti;
            }
            set
            {
                if (value.Count < 2)
                    throw new Exception("Lista non valida");
                _listaPartecipanti = value;
            }
        }

        public Partecipante Vincitore
        {
            get;
            set;
        }

        private Partecipante GetVincitore()
        {
            return Vincitore;
        }
    }
}