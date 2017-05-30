using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            int y = -1;
            x.Iscap();
            y.Iscap();
            Console.WriteLine(x + "is Capitalized? " );
            Console.WriteLine(y + "is Capitalized? " );
        }
    }

    public static class StringCap
    {
        public static void Iscap(this int s)
        {
        }
    }
}
