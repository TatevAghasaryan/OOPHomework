using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class Engineer : ISpecialty
    {
        public string Name { get; set; }
        public string Salary { get; set; }
        
        public ISpecialty Clone()
        {
            return (ISpecialty)this.MemberwiseClone();
        }

        public void GetInformation()
        {
            Console.WriteLine("Name: {0} Salary: {1}",Name, Salary);
        }
    }
}
