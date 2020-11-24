﻿using System;
using System.Collections.Generic;

namespace Data.Models_Tourlewi
{
    public partial class ChangbayLog
    {
        public decimal Id { get; set; }
        public string Sgtcode { get; set; }
        public int Order { get; set; }
        public string Hanhtrinh { get; set; }
        public decimal? Giavenl { get; set; }
        public decimal? Giavete { get; set; }
        public decimal? Giaveeb { get; set; }
        public int? Socho { get; set; }
        public string Ghichu { get; set; }
        public string Type { get; set; }
        public DateTime? Ngaysua { get; set; }
        public string Nguoisua { get; set; }
        public string Maytinh { get; set; }
    }
}
