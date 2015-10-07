using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalizationSpecialization
{
    public class EmailingList
    {
        private List<EmailContact> _emailingList { get; set; }
        public EmailingList()
        {
            _emailingList = new List<EmailContact>();
        }

        public void Add(EmailContact contact)
        {
            _emailingList.Add(contact);
        }

        
    }
}
