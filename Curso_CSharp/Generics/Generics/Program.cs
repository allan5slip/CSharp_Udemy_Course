using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Collections.ArrayList list1 = new System.Collections.ArrayList();

            list1.Add(3);
            list1.Add(5);
            list1.Add(12);
            //list1.Add("Hello");

            Console.WriteLine("NonSerializedAttribute-Generics List Results");;

            foreach (int x in list1)
            {
                Console.WriteLine(x);
            }

            List<int> list2 = new List<int>();

            list2.Add(34);
            list2.Add(9);
            list2.Add(21);

            Console.WriteLine("Generic list Results");

            foreach (int item in list2)
            {
                Console.WriteLine(item);
            }

        }
    }
}
