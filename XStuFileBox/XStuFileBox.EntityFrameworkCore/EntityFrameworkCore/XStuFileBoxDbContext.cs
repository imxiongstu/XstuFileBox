using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStuFileBox.Domain.Entitys;

namespace XStuFileBox.EntityFrameworkCore.EntityFrameworkCore
{
    public class XStuFileBoxDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public XStuFileBoxDbContext(DbContextOptions<XStuFileBoxDbContext> options) : base(options)
        {

        }
    }
}
