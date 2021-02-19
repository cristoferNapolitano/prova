using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bookmaker
{
    public class Scommessa
    {
        private int _importo;
        public int Importo
        {
            get => _importo;
            set
            {
                if (value < 1)
                    throw new Exception("Importo non valido");
                _importo = value;
            }
        }

        public Corsa Corsa
        {
            get;
            set;
        }

        public Partecipante PartecipanteScommesso
        {
            get;
            set;
        }

        private int _quotazione;
        public int Quotazione
        {
            get
            {
                return _quotazione;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Quotazione non valida");
                _quotazione = value;
            }
        }

        public Scommessa(int importo, Corsa corsa, Partecipante partecipanteScommesso, int quotazione, Scommettitore scommettitore)
        {
            Importo = importo;
            Corsa = corsa;
            PartecipanteScommesso = partecipanteScommesso;
            Quotazione = quotazione;
            Scommettitore = scommettitore;
        }

        public Scommettitore Scommettitore
        {
            get;
            set;
        }
    }
}