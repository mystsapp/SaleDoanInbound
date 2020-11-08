﻿using Data.Dtos;
using Data.Models_IB;
using Data.Models_QLT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace SaleDoanInbound.Models
{
    public class BienNhanViewModel
    {
        public IEnumerable<BienNhanDto> BienNhans { get; set; }
        public IPagedList<BienNhanDto> BienNhanPagedList { get; set; }
        public IEnumerable<ChiTietBN> ChiTietBNs { get; set; }
        public IEnumerable<CacNoiDungHuyTour> CacNoiDungHuyTours { get; set; }
        public BienNhan BienNhan { get; set; }
        public IEnumerable<Ngoaite> Ngoaites { get; set; } // qltour
        public Tour Tour { get; set; }
        public TourIB TourIB { get; set; }
        public string StrUrl { get; set; }
        public string SoTienBangChu { get; set; }

        public ListViewModel ChiTietBNPrint { get; set; }

    }
}
