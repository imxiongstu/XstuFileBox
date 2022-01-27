using Autofac;
using Autofac.Extras.DynamicProxy;
using System.Reflection;
using XStuFileBox.Application;
using XStuFileBox.Core.Aop;
using XStuFileBox.Domain.UnitOfWorks;
using XStuFileBox.EntityFrameworkCore.EntityFrameworkCore.Repositorys;
using XStuFileBox.EntityFrameworkCore.EntityFrameworkCore.UnitOfWorks;
using Module = Autofac.Module;
namespace XStuFileBox.HttpApi.Autofac
{
    public class AutofacServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //注入泛型仓储
            builder.RegisterGeneric(typeof(Repository<>)).AsImplementedInterfaces().InstancePerLifetimeScope();

            //注入Uow
            builder.RegisterType(typeof(UnitOfWorkAop));

            //注册Application层所有服务(约定以Service结尾),并启用Uow
            var serviceAssembly = typeof(XStuFileBoxServiceModule).GetTypeInfo().Assembly;
            builder.RegisterAssemblyTypes(serviceAssembly)
                   .Where(o => o.Name.EndsWith("Service"))
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope()
                   .EnableInterfaceInterceptors()
                   .InterceptedBy(typeof(UnitOfWorkAop));
        }
    }
}
