using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ValueObjects;

namespace Models.Facultate
{
    public class Profesor
    {
        private  PlainText numeprofesor;
        private  Cnp codpersonal;
        private Varsta varsta;
       
        public Profesor(PlainText numeprofesor, Cnp codpersonal, Varsta varsta)
        {
            this.numeprofesor = numeprofesor;
            this.codpersonal = codpersonal;
            this.varsta = varsta;
        }

        public PlainText Numeprofesor
        {
           get { return this.numeprofesor; }
           private set { this.numeprofesor = value; }
        }

        public Cnp Codpersonal
        {
            get { return this.codpersonal; }
            private set { this.codpersonal = value; }
        }

        public Varsta Varsta
        { 
            get { return this.varsta; }
            private set { this.varsta = value; }
        }


    }
}
