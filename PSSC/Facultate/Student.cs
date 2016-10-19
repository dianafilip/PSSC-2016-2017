using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student
    {
        private string nume;
        private string facultate;
        private string serie;
        private int an;


        public Student(string nume, string facultate, string serie, int an)
        {
            this.nume = nume;
            this.facultate = facultate;
            this.serie = serie;
            this.an = an;
        }
    }
}
