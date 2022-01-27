using Microsoft.EntityFrameworkCore;
using XStuFileBox.Domain.UnitOfWorks;
using XStuFileBox.EntityFrameworkCore.EntityFrameworkCore.UnitOfWorks;

namespace XStuFileBox.HttpApi.Extensions
{
    public static class UnitOfWorkServiceExtensions
    {
        public static void AddUnitOfWork<TDbContext>(this IServiceCollection services)
           where TDbContext : DbContext
        {
            services.AddScoped<IUnitOfWork, UnitOfWork<TDbContext>>();
        }
    }
}
