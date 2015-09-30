using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
    public class University
    {
        public Address Address { get; set; }
        public string Name { get; set; }
        public List<Faculty> Faculties { get; set; }
        
    }
}
