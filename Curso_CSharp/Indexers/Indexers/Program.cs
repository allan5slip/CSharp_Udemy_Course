
namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c[1] = "Mercedes";
            c[2] = " doge";
            c[3] = "Chevrolet";
            c[4] = "Honda";


            System.Console.WriteLine("Car 1 is: "+ c[1]);
            System.Console.WriteLine("Car 2 is: " + c[2]);
            System.Console.WriteLine("Car 3 is: " + c[39]);

        }
    }


    public class Car
    {
        string[] car = new string[40];

        public string this[int carNum]
        {
            get
            {
                if (carNum >= 0 && carNum < car.Length)
                {
                    return car[carNum];
                }
                return "Out of index range...";
            }
            set
            {
                if (carNum >= 0 && carNum < car.Length)
                {
                    car[carNum] = value;
                }

            }
        }
    }
}
