﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeAPITest1
{
    public class Account
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public List<ProductHistory> productHistory { get; set; }
    }
}