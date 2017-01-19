using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PSSC.Models
{
    [Table("Facultate")]
    public class Facultate
    {
        [Key]
        [Required()]                 
        public int IdFacultate { get; set; }

        [Required()]
        public string NumeFacultate { get; set; }
        [Required()]
        public string SpecializareFacultate { get; set; }

        public virtual List<Student> Studenti { get; set; }
    }
}