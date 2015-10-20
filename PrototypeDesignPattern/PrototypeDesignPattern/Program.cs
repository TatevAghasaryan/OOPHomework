using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Engineer engineer = new Engineer();
            engineer.Name = "Tatev Aghasaryan";
            engineer.Salary = "200.000";
            engineer.GetInformation();

            Engineer engineerCopy = (Engineer)engineer.Clone();
            engineerCopy.Name = "Poghos Poghosyan";
            engineerCopy.GetInformation();

            Console.ReadKey();
        }
    }
}
