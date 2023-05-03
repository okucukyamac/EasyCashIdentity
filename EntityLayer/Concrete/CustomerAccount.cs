﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CustomerAccount
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }
        public string BankBranch{ get; set; }
    }
}
