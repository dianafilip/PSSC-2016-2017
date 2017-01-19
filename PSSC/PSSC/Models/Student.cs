using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PSSC.Models
{
    public class Student
    {
        [Required()]
        [Key]
        public int IdStudent { get; set; }

        [Required()]
        public string Nume { get; set; }
        [Required()]
        public int Varsta { get; set; }

        public int IdFacultate { get; set; }
        public virtual Facultate Facultate { get; set; }

    }
}