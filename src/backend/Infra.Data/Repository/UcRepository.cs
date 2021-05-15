using backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Infra.Data;
using backend.Domain.Interfaces;

namespace backend.Infra.Data.Repository
{
    public class UcRepository : IUcRepository
    {
        private readonly CSV.IContext _context;

        public UcRepository(CSV.IContext context) => _context = context;

        public Uc Get(long id)
        {
            return _context.Ucs.First(u => u.Id == id);
        }

        public IEnumerable<Uc> GetAll()
        {
            return _context.Ucs;            
        }

    }
}
