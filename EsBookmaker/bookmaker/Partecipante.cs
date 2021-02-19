using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bookmaker
{
    public class Partecipante
    {
        private int _numero;

        public Partecipante(int num, Cavallo c, Fantino f)
        {
            Numero = num;
            Cavallo = c;
            Fantino = f;
        }

        public int Numero
        {
            get => _numero;
            set
            {
                if (value < 1)
                    throw new Exception("Valore non valido");
                _numero = value;
            }
        }

        public Cavallo Cavallo
        {
            get;
            set;
        }

        public Fantino Fantino
        {
            get;
            set;
        }
    }
}