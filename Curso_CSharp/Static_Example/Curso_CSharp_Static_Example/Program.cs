using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp_Static_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = Math.Round(35.3);

            Console.WriteLine(r);

            Car.Accelerate();

            Car c = new Car();

            c.SlowDown();
        }
    }


    public class Car
    {
        public static void Accelerate()
        {
            Console.WriteLine("Car is Accelerating");
        }

        public void SlowDown()
        {
            Console.WriteLine("Car is SlowDown");
        }
    }
}
