using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Profesor
    {
        private string nume_profesor;
       
        public Profesor(string nume_profesor)
        {
            this.nume_profesor = nume_profesor;
        }

        public string Nume_profesor
        {
           get { return this.nume_profesor; }
           set { this.nume_profesor = value; }
        }

    }
}
