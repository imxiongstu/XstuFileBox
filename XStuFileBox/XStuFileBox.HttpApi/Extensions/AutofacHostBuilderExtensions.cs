using Autofac;
using Autofac.Extensions.DependencyInjection;
using XStuFileBox.HttpApi.Autofac;

namespace XStuFileBox.HttpApi.Extensions
{
    public static class AutofacHostBuilderExtensions
    {
        /// <summary>
        /// 使用Autofac
        /// </summary>
        /// <param name="builder"></param>
        public static void UseAutofac(this WebApplicationBuilder builder)
        {
            // 将内置的注入Factory替换为Autofac
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory(builder =>
            {
                builder.RegisterModule(new AutofacServiceModule());
            }));
        }
    }
}
