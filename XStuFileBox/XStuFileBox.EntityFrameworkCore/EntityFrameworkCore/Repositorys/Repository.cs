using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStuFileBox.Domain.EntityRoot;
using XStuFileBox.Domain.Repositorys;

namespace XStuFileBox.EntityFrameworkCore.EntityFrameworkCore.Repositorys
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
    }
}
