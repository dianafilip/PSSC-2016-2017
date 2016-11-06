using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ValueObjects
{
  public class Varsta // clasa folosita pt a verifica ca nu sunt persoana <18 la facultate
    {
        private int ani;

        public Varsta(int ani)
        {
            if (ani.ToString().Length >= 18) // daca are 13 cifre atunci il seteaza
                this.ani = ani;
            else
                throw new ArgumentOutOfRangeException();
        }

        public int Ani
        {
            get { return this.ani; }
        }


        public override bool Equals(object obj)
        {
            return ani.Equals(obj);
        }

        public override int GetHashCode()
        {
            return ani.GetHashCode();
        }

        public override string ToString()
        {
            return ani.ToString();
        }
    }
}

