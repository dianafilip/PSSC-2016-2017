using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ValueObjects;

namespace Models.Facultate
{
    class Facultate
    {
        private PlainText numefacultate; // identificator unic pentru facultate;
        private List<Student> Studenti;
        private List<Profesor> Profesori;
        private List<Disciplina> Discipline;

        public Facultate(PlainText numefacultate)
        {
            this.numefacultate = numefacultate;
            Studenti = new List<Student>(); // lista initial e goala
            Profesori = new List<Profesor>();
            Discipline = new List<Disciplina>();

        }

        public IEnumerable<Student> ListaStudenti // Afisare studenti
        {
            get { return Studenti; }
        }

        public IEnumerable<Profesor> ListaProfesori // Afisare profesori
        {
            get { return Profesori; }
        }

        public IEnumerable<Disciplina> ListaDiscipline // Afisare materii
        {
            get { return Discipline; }
        }

        public void AdaugareStudent(Student student)
        {
            if (Studenti.Contains(student))
                throw new DuplicateException();
            else
                Studenti.Add(student);
        }

        public void AdaugareProfesor(Profesor profesor)
        {
            if (Profesori.Contains(profesor))
                throw new DuplicateException();
            else
                Profesori.Add(profesor);
        }

        public void AdaugareMaterie(Disciplina materie)
        {
            if (Discipline.Contains(materie))
                throw new DuplicateException();
            else
                Discipline.Add(materie);
        }

        public override bool Equals(object obj)
        {
            return numefacultate.Equals(obj);
        }

        public override int GetHashCode()
        {
            return numefacultate.GetHashCode();
        }

        public override string ToString()
        {
            return numefacultate.ToString();
        }
    }
}
