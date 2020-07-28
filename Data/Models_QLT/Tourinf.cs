﻿using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Tourinf
    {
        public Tourinf()
        {
            Tourprog = new HashSet<Tourprog>();
        }

        public string Sgtcode { get; set; }
        public bool Khachle { get; set; }
        public string CompanyId { get; set; }
        public int? TourkindId { get; set; }
        public DateTime Arr { get; set; }
        public DateTime Dep { get; set; }
        public int? Pax { get; set; }
        public int? Childern { get; set; }
        public string Concernto { get; set; }
        public string Operators { get; set; }
        public string Departoperator { get; set; }
        public string Reference { get; set; }
        public string Routing { get; set; }
        public DateTime? Cancel { get; set; }
        public string Cancelnote { get; set; }
        public string Entryport { get; set; }
        public string Entryby { get; set; }
        public string Note { get; set; }
        public string Visa { get; set; }
        public string Passtype { get; set; }
        public decimal? Revenue { get; set; }
        public string Currency { get; set; }
        public decimal? Rate { get; set; }
        public DateTime? Createtour { get; set; }
        public DateTime? Locktour { get; set; }
        public string Userlock { get; set; }
        public string Chinhanh { get; set; }
        public string Logfile { get; set; }

        public virtual ICollection<Tourprog> Tourprog { get; set; }
    }
}
