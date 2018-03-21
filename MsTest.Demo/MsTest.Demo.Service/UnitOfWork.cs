using MsTest.Demo.Contract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTest.Demo.Service
{
    class UnitOfWork : IUnitOfWork
    {
        private DbContext _context;
        public UnitOfWork(DbContext dbContext)
        {
            _context = dbContext;
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
