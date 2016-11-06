using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ValueObjects;

namespace Models.Facultate
{

   public class Student
    {
        private PlainText nume;
        private Cnp codpersonal;
        private NumarMatricol nr;
        private Varsta varsta;
        private string serie;
        private int an;


        public Student(PlainText nume, Cnp codpersonal, NumarMatricol nr,  Varsta varsta, string serie, int an)
        {
            this.nume = nume;
            this.codpersonal = codpersonal;
            this.nr = nr;
            this.varsta = varsta;
            this.serie = serie;
            this.an = an;
        }

        public PlainText Nume
        {
            get { return this.nume; }
            private set { this.nume = value; }
        }

        public string Serie
        {
            get { return this.serie; }
            private set { this.serie = value; }
        }

        public int An
        {
            get { return this.an; }
            private set { this.an = value; }

        }

        public Cnp CodPersonal
            {
            get { return this.codpersonal;}
            private set { this.codpersonal = value; }
            }

        public NumarMatricol Numar
        {
            get { return this.nr; }
            private set { this.nr = value; }
        }

        public Varsta Varsta
        {
            get { return this.varsta; }
            private set { this.varsta = value; }
        }

    }
}
