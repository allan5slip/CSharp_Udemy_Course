using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp_Udemy
{
    class Program
    {
        static void Main(string[] args)
        {

            AddConstructor ac = new AddConstructor();
        }
    }


    public class DefConstructor
    {
        public void DoThis()
        {
            Console.WriteLine("DoThis has run...");
        }
    }


    public class AddConstructor
    {
        public AddConstructor()
        {
            Console.WriteLine("The constructor has ebn called..."); ;
            DoThat();
        }

        public void DoThat()
        {
            Console.WriteLine("DoThat has Executed...");
        }
    }
}
