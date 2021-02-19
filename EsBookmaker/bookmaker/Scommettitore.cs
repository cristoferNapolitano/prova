using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bookmaker
{
    public class Scommettitore
    {
        public Scommettitore(string nome)
        {
            Nome = nome;
        }

        private string _nome;
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