﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBase.Model
{

    public class Customer
    {
        public int Id { get; set; }
        public string DNI { get; set; }
        public string Name{ get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Customer (){

            }
    }
    
}
