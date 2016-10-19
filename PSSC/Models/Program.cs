using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Program
    {
        static void Main()
        {

            Student s = new Student("Diana","AC","IS",4);
            s.afisare();
            

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
