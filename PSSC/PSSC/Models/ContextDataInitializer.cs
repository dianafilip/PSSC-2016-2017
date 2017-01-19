using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PSSC.Models
{
    public class ContextDataInitializer : DropCreateDatabaseAlways<ContextFacultate>
    {
        protected override void Seed(ContextFacultate context)
        {

            Facultate facultate1 = new Facultate() {IdFacultate=1, NumeFacultate = "Automatica si Calculatoare", SpecializareFacultate = "Ingineria Programarii" };
            Facultate facultate2 = new Facultate() {IdFacultate=2, NumeFacultate = "Energetica si Electronica", SpecializareFacultate = "Inginerie Electrica" };

            context.Studenti.Add(new Student() {Nume="Filip Diana",Varsta=22, Facultate=facultate1 });
            context.Studenti.Add(new Student() { Nume = "Forgacs Norbert", Varsta = 23, Facultate = facultate1 });
            context.Studenti.Add(new Student() { Nume = "Mandru Miruna", Varsta = 22, Facultate = facultate1 });
            context.Studenti.Add(new Student() { Nume = "Salam Iosefina", Varsta = 24, Facultate = facultate2 });
            context.Studenti.Add(new Student() { Nume = "Chirurgie Anabela", Varsta = 25, Facultate = facultate2 });
            context.Studenti.Add(new Student() { Nume = "Motel Andrei", Varsta = 21, Facultate = facultate1 });
            context.Studenti.Add(new Student() { Nume = "Sarman Darius", Varsta = 22, Facultate = facultate1 });
            context.Studenti.Add(new Student() { Nume = "Cocos Mihai", Varsta = 24, Facultate = facultate1 });
            context.Studenti.Add(new Student() { Nume = "Roxana Todorut", Varsta = 22, Facultate = facultate1 });


            context.SaveChanges();
        }
    }
}