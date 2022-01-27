using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStuFileBox.Domain.UnitOfWorks;

namespace XStuFileBox.EntityFrameworkCore.EntityFrameworkCore.UnitOfWorks
{
    public class UnitOfWork<TDbContext> : IUnitOfWork, IDisposable where TDbContext : DbContext
    {
        public readonly TDbContext _dbContext;
        public UnitOfWork(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void BeginTransaction()
        {
            _dbContext.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _dbContext.Database.CommitTransaction();
        }

        public void RollBackTransaction()
        {
            _dbContext.Database.RollbackTransaction();
        }

        public void Dispose()
        {
            //_dbContext.Dispose();
        }
    }
}
