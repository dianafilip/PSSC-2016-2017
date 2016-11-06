using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ValueObjects
{
  public class Cnp
    {
        private string cod; //folosit pt cnp

        public Cnp(string cod)
        {
            if (cod == null)
                throw new ArgumentNullException();
            if (cod.Length == 13) // daca are 13 cifre atunci il seteaza
                this.cod = cod;
            else
                throw new ArgumentOutOfRangeException();
        }

        public string Cod
        {
            get { return this.cod; }
        }


        public override bool Equals(object obj)
        {
            return cod.Equals(obj);
        }

        public override int GetHashCode()
        {
            return cod.GetHashCode();
        }

        public override string ToString()
        {
            return cod.ToString();
        }
    }
}

