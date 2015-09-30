using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
    public class Student : Person
    {
        public Student()
        {
            
        }
        public Student(string name, Address address, University university, Faculty faculty)
        {
            Id = Guid.NewGuid();
            FullName = name;
            Address = address;
            University = university;            
        }
        public Guid Id { get; private set; }        
        public University University { get; set; }
        public Faculty Faculty { get; set; }
    }
}
