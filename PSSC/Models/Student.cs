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
        private List<Disciplina> disciplina=new List<Disciplina>();


        public Student(string nume, string facultate, string serie, int an, List<Disciplina> disciplina)
        {
            this.nume = nume;
            this.facultate = facultate;
            this.serie = serie;
            this.an = an;
            this.disciplina = disciplina;
        }

        public string Nume
        {
            get { return this.nume; }
            set { this.nume = value; }
        }

        public string Facultate
        {
            get { return this.facultate; }
            set { this.facultate = value; }

        }

        public string Serie
        {
            get { return this.serie; }
            set { this.serie = value; }
        }

        public int An
        {
            get { return this.an; }
            set { this.an = value; }

        }

        public List<Disciplina> Disciplina
        {
            get { return this.disciplina; }
            set { this.disciplina = value; }

        }

        public void afisare()
        {
            Console.WriteLine("Nume: " + Nume + "\nFacultate: " + Facultate + "\nSerie: " + Serie + "\nAn: " + An);
        }

    }
}
