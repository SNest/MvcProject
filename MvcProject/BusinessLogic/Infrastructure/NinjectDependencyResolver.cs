using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Domain.Repositories.Abstract;
using Domain.Repositories.Concrete;
using Ninject;

namespace BusinessLogic.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly string connectionString;
        private readonly IKernel kernel;

        public NinjectDependencyResolver(string connection)
        {
            connectionString = connection;
            kernel = new StandardKernel();
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IArticleRepository>().To<EFArticleRepository>().WithConstructorArgument(connectionString);
            kernel.Bind<IFeedbackRepository>().To<EFFeedbackRepository>().WithConstructorArgument(connectionString);
            kernel.Bind<IMarkRepository>().To<EFMarkRepository>().WithConstructorArgument(connectionString);
            kernel.Bind<IUserRepository>().To<EFUserRepository>().WithConstructorArgument(connectionString);
        }
    }
}