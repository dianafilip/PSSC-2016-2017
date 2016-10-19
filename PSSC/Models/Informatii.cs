using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Informatii
    {
        private List<Student> student=new List<Student>();
        private string prezente;
        private List<float> note_activitate=new List<float>();
        private List<float> note_exam=new List<float>();

        // o functie care calculeaza media finala

        public Informatii(List<Student> student, string prezente, List<float> note_activitate, List<float> note_exam)
        {
            this.student = student;
            this.prezente = prezente;
            this.note_activitate = note_activitate;
            this.note_exam = note_exam;
        }

        public List<Student> Student
        {
            get { return this.student; }
            set { this.student = value; }

        }

        public string Prezente
        {
            get { return this.prezente; }
            set { this.prezente = value; }
        }

        public List<float> Note_ativitate
        {
            get { return this.note_activitate; }
            set { this.note_activitate = value; }

        }

        public List<float> Note_examen
        {
            get { return this.note_exam; }
            set { this.note_exam = value; }

        }

    }
}
