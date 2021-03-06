﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalizationSpecialization
{
    public class EmailContact:IEmailContact
    {
        public EmailContact()
        {
            FullName = string.Empty;
            Email = string.Empty;
        }
        public EmailContact(IEmailContact contact)
        {
            FullName = contact.FullName;
            Email = contact.Email;
        }
        public string Email { get; set; }
        public string FullName { get; set; }
        public override string ToString()
        {
            return string.Format("{0}<{1}>",FullName,Email);
        }
            
    }
}
