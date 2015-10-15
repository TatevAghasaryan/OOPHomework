using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string carType = Console.ReadLine();

            if (carType == "BMW")
            {
                Director car = new Director();
                IBuilder build = new BMW();
                car.ConstructCar(build);
            }

            if (carType == "Mercedes")
            {
                Director car = new Director();
                IBuilder build = new Mercedes();
                car.ConstructCar(build);
            }

            Console.ReadKey();
        }
    }
}
