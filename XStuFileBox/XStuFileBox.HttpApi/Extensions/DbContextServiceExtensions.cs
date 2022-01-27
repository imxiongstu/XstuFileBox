using Microsoft.EntityFrameworkCore;
using XStuFileBox.Common.Configure;
using XStuFileBox.EntityFrameworkCore.EntityFrameworkCore;

namespace XStuFileBox.HttpApi.Extensions
{
    public static class DbContextServiceExtensions
    {
        /// <summary>
        /// 注入DbContext
        /// </summary>
        /// <param name="services"></param>
        public static void AddDbContext(this IServiceCollection services)
        {
            services.AddDbContext<XStuFileBoxDbContext>(options =>
            {
                options.UseMySql(AppSettings.Get("ConnectionStrings:MySqlConnectionString"),
                    ServerVersion.Parse("5.7"));
            });
        }
    }
}
