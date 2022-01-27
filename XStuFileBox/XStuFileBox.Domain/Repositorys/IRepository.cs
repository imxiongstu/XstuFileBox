using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using XStuFileBox.Domain.EntityRoot;

namespace XStuFileBox.Domain.Repositorys
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> InsertAsync(TEntity entity);
    }
}
