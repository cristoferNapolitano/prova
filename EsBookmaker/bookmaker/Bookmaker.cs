using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bookmaker
{
    public class Bookmaker
    {

        private string _nome;
        public string Nome
        {
            get => _nome;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("Valore non valido");
                _nome = value;
            }
        }

        public Bookmaker(string nome, List<Corsa> corse, List<Scommessa> scommesse, List<Scommettitore> scommettitori)
        {
            Nome = nome;
            Corse = corse;
            Scommesse = scommesse;
            Scommettitori = scommettitori;
        }

        public List<Corsa> Corse
        {
            get;
            set;
        }

        public List<Scommessa> Scommesse
        {
            get;
            set;
        }

        public List<Scommettitore> Scommettitori
        {
            get;
            set;
        }

        public void AddScommessa(Scommessa s)
        {
            Scommesse.Add(s);
        }

        public int PagaScommessa(int i)
        {
            try
            {
                return Scommesse[i].Quotazione * Scommesse[i].Importo;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}