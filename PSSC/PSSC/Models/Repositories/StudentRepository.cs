using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSSC.Models.Repositories
{

    public class StudentRepository : Repository<Student>
    {
        public List<Student> GetByName(String name)
        {
            return DbSet.Where(a => a.Nume.Contains(name)).ToList();
        }
    }
}