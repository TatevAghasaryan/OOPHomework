using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class BMW : IBuilder
    {
        public void CreateCar()
        {
            Console.WriteLine("BMW");
        }
    }
}
