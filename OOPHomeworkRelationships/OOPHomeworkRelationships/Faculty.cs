﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
    public class Faculty
    {
        public Faculty(string name, string code)
        {
            Name = name;
            Code = code;
        }
        public string Name { get; set; }
        public string Code { get; set; }

    }
}
