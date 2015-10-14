using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 3; i++)
            {
                Specialty specialty = Factory.Get(i);
                Console.WriteLine("Id = {0} Specialty = {1}",i,specialty.Title);

                
            }
            Console.ReadKey();
        }
    }
}
