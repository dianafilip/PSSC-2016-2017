using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PSSC.Models
{
    public class ContextStudentDbContext
    {
        public DbSet<Student> Studenti { get; set; }

    
    }
}