﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PDC03_MOD04
{
    internal class Contacts
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Occupation { get; set; }


        public string Country { get; set; }

        public override string ToString()
        {
            return Name;
        }


    }
}
