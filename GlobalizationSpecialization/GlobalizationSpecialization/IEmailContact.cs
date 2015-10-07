using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalizationSpecialization
{
    public interface IEmailContact
    {
        string Email { get; set; }
        string FullName { get; set; }
    }
}
