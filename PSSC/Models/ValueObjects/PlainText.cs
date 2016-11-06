using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ValueObjects
{
  public class PlainText
    {
        private string nume;
        public PlainText(string nume) // clasa value object folosita pentru nume:nume student, profesor, disciplina ...
        {
            if (nume == null)  
                throw new ArgumentNullException();
            if (nume.Any(c => char.IsDigit(c)) == true) // daca are cifre arunca o exceptie
                throw new ArgumentOutOfRangeException();
            this.nume = nume;

        }

        public string Nume 
        {
            get { return this.nume; }
        }


        public override bool Equals(object obj)
        {
            return nume.Equals(obj);
        }

        public override int GetHashCode()
        {
            return nume.GetHashCode();
        }

        public override string ToString()
        {
            return nume.ToString();
        }
    }

}
