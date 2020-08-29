﻿using Data.Models_QLT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface ISupplierRepository
    {
        IEnumerable<Supplier> GetAll();

        Task<Supplier> GetByIdAsync(string id);

        IEnumerable<Supplier> Find(Func<Supplier, bool> predicate);
    }
    public class SupplierRepository : ISupplierRepository
    {
        private readonly qltourContext _qltourContext;

        public SupplierRepository(qltourContext qltourContext)
        {
            _qltourContext = qltourContext;
        }
        public IEnumerable<Supplier> Find(Func<Supplier, bool> predicate)
        {
            return _qltourContext.Supplier.Where(predicate);
        }

        public IEnumerable<Supplier> GetAll()
        {
            return _qltourContext.Supplier;
        }

        public async Task<Supplier> GetByIdAsync(string id)
        {
            return await _qltourContext.Supplier.FindAsync(id);
        }
    }
}
