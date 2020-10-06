﻿using Data.Dtos;
using Data.Models_IB;
using Data.Models_QLT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleDoanInbound.Models
{
    public class BaoCaoViewModel
    {
        public string TuNgay { get; set; }
        public string DenNgay { get; set; }
        public IEnumerable<Dmchinhanh> Dmchinhanhs { get; set; }
        public IEnumerable<TourDto> TourDtos { get; set; }
    }
}
