using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSSC.Models.Repositories
{
    public class FacultateRepository: Repository<Facultate>
    {
        public List<Facultate> GetByName(String name)
        {
            return DbSet.Where(a => a.NumeFacultate.Contains(name)).ToList();
        }
    }
}