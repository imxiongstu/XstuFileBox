using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using XStuFileBox.Domain.EntityRoot;
using XStuFileBox.Domain.Repositorys;

namespace XStuFileBox.EntityFrameworkCore.EntityFrameworkCore.Repositorys
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        public readonly XStuFileBoxDbContext _dbContext;

        public Repository(XStuFileBoxDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbContext.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            var saveEntity = (await _dbContext.Set<TEntity>().AddAsync(entity)).Entity;
            await _dbContext.SaveChangesAsync();
            return saveEntity;
        }
    }
}
