using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ValueObjects;

namespace Models.Facultate
{
  public class Disciplina
    {
        private PlainText numedisciplina;
        private string credite; // cate credite are materia;
        private Profesor profesor; //profesorul care este titular
        private int ore; // cate ore se face disciplina respectiva


        public Disciplina(PlainText numedisciplina, string credite, Profesor profesor, int ore)
        {
            this.numedisciplina = numedisciplina;
            this.credite = credite;
            this.profesor = profesor;
            this.ore = ore;
        }

        public PlainText Numedisciplina
        {
            get { return this.numedisciplina; }
            private set { this.numedisciplina = value; }
        }

        public string Credite
        {
            get { return this.credite; }
            private set { this.credite= value; }
        }

        public Profesor Profesor
        {
            get { return this.profesor; }
            private set { this.profesor = value; }
        }

        public int Ore
        {
            get { return this.ore; }
            private set { this.ore = value; }
        }
    }
}
