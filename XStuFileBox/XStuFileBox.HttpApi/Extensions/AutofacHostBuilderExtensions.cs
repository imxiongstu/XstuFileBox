using Autofac;
using Autofac.Extensions.DependencyInjection;
using XStuFileBox.HttpApi.Autofac;

namespace XStuFileBox.HttpApi.Extensions
{
    public static class AutofacHostBuilderExtensions
    {
        public static void UseAutofac(this WebApplicationBuilder builder)
        {
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory(builder =>
            {
                builder.RegisterModule(new AutofacServiceModule());
            }));
        }
    }
}
