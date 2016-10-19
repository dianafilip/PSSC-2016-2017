using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Disciplina
    {
        private string nume_disciplina;
        private string credite;
        private Profesor profesor;
        private int ore;


        public Disciplina(string nume_disciplina, string credite, Profesor profesor, int ore)
        {
            this.nume_disciplina = nume_disciplina;
            this.credite = credite;
            this.profesor = profesor;
            this.ore = ore;
        }

        public string Nume_disciplina
        {
            get { return this.nume_disciplina; }
            set { this.nume_disciplina = value; }
        }

        public string Credite
        {
            get { return this.credite; }
            set { this.credite= value; }
        }

        public Profesor Profesor
        {
            get { return this.profesor; }
            set { this.profesor = value; }
        }

        public int Ore
        {
            get { return this.ore; }
            set { this.ore = value; }
        }
    }
}
