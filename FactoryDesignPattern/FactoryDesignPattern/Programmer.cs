using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Programmer : Specialty
    {
        public override string Title
        {
            get { return "Programmer"; }
        }
    }
}
