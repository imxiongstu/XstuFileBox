using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStuFileBox.Domain.UnitOfWorks;

namespace XStuFileBox.Core.Aop
{
    public class UnitOfWorkAop : IInterceptor
    {
        private readonly IUnitOfWork _unitOfWork;

        public UnitOfWorkAop(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Intercept(IInvocation invocation)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                Console.WriteLine("开始事务...");
                invocation.Proceed();
                _unitOfWork.CommitTransaction();
                Console.WriteLine("提交事务...");
            }
            catch (Exception)
            {
                _unitOfWork.RollBackTransaction();
                Console.WriteLine("回滚事务...");
            }
            _unitOfWork.Dispose();
        }

    }
}
