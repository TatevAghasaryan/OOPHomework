using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public static class Factory
    {
        public static Specialty Get(int id)
        {
            switch(id)
            {
                case 0: return new Manager(); break;
                case 1:
                case 2: return new Driver(); break;
                case 3:
                default: return new Programmer(); break;
            }
        }
    }
}
