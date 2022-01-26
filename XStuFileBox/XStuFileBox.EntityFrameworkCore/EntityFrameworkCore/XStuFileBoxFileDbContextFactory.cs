using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XStuFileBox.EntityFrameworkCore.EntityFrameworkCore
{
    public class XStuFileBoxFileDbContextFactory : IDesignTimeDbContextFactory<XStuFileBoxDbContext>
    {
        public XStuFileBoxDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();
            var builder = new DbContextOptionsBuilder<XStuFileBoxDbContext>()
                .UseMySql(configuration.GetConnectionString("MySqlConnectionString"), ServerVersion.Parse("5.7"));

            return new XStuFileBoxDbContext(builder.Options);
        }


        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }

    }
}
