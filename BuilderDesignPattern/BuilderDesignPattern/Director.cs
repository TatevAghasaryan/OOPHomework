using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Director
    {
        public void ConstructCar(IBuilder build)
        {
            build.CreateCar();
        }
    }
}
