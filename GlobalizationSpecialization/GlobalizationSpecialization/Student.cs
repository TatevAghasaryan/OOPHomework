using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalizationSpecialization
{
    public class Student : Contact, IEmailContact
    {
        public TrainingCourse Course { get; set; }

        public string Email { get; set; }


        public new string FullName { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1} <{2}>;", FirstName, LastName, Email);
        }
        
    }
}
