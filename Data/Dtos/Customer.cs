﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Dtos
{
    public class Customer
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string TaxCode { get; set; }
        public string Address { get; set; }
        public string BankAccountName { get; set; }
        public string BankName { get; set; }
        public string BankNumber { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string ContactPerson { get; set; }
        public string RepresentPerson { get; set; }
        public string CusType { get; set; }
    }
}
