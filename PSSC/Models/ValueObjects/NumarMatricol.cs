using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ValueObjects
{
  public class NumarMatricol
    {
        private int numar;
       
        public NumarMatricol(int numar)
        {
            if (numar.ToString().Length== 4) //Daca numarul matricol=4 atunci il seteaza
                this.numar = numar;
           else
                throw new ArgumentOutOfRangeException();
        }

        public int Numar
        {
            get { return this.numar; }
        }


        public override bool Equals(object obj)
        {
            return numar.Equals(obj);
        }

        public override int GetHashCode()
        {
            return numar.GetHashCode();
        }

        public override string ToString()
        {
            return numar.ToString();
        }
    }
}

