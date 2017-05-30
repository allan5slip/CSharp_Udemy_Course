using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overridding
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.Exame();

            Patient a = new Adult();
            a.Exame();
        }
    }

    public class Patient
    {
        public virtual void Exame()
        {
            Console.WriteLine("The patienit has been examined..");

        }
    }
    

    public class Adult : Patient
    {
        public override void Exame()
        {
            Console.WriteLine("The adult has been examed...");
        }
    }
}