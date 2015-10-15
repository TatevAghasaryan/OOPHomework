using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Mercedes : IBuilder
    {

        public void CreateCar()
        {
            Console.WriteLine("Mercedes");
        }
    }
}
