﻿using Data.Interfaces;
using Data.Models_IB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using X.PagedList;

namespace Data.Repository
{
    public interface IKhuVucTGRepository : IRepository<KhuVuc>
    {
        IPagedList<KhuVuc> ListKhuVucTG(string searchString, int? page);
    }
    public class KhuVucTGRepository : Repository<KhuVuc>, IKhuVucTGRepository
    {
        public KhuVucTGRepository(SaleDoanIBDbContext context) : base(context)
        {
        }

        public IPagedList<KhuVuc> ListKhuVucTG(string searchString, int? page)
        {
            // return a 404 if user browses to before the first page
            if (page.HasValue && page < 1)
                return null;

            // retrieve list from database/whereverand

            var list = GetAll().AsQueryable();
            if (!string.IsNullOrEmpty(searchString))
            {
                list = list.Where(x => x.TenKhu.ToLower().Contains(searchString.ToLower()));
            }

            var count = list.Count();

            // page the list
            const int pageSize = 2;
            decimal aa = (decimal)list.Count() / (decimal)pageSize;
            var bb = Math.Ceiling(aa);
            if (page > bb)
            {
                page--;
            }
            page = (page == 0) ? 1 : page;
            var listPaged = list.ToPagedList(page ?? 1, pageSize);
            //if (page > listPaged.PageCount)
            //    page--;
            // return a 404 if user browses to pages beyond last page. special case first page if no items exist
            if (listPaged.PageNumber != 1 && page.HasValue && page > listPaged.PageCount)
                return null;


            return listPaged;
        }
    }
}
