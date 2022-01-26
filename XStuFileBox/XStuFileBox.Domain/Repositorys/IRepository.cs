using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStuFileBox.Domain.EntityRoot;

namespace XStuFileBox.Domain.Repositorys
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
    }
}
