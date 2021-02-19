using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bookmaker
{
    public class Cavallo
    {
        private string _nome;

        public Cavallo(string n)
        {
            Nome = n;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("Nome non valido");
                _nome = value;
            }
        }

        
    }
}