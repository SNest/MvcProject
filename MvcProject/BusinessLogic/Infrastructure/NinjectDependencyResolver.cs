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
        IKernel kernel;

        public NinjectDependencyResolver()
        {
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

        void AddBindings()
        {
            kernel.Bind<IArticleRepository>().To<EFArticleRepository>();
            kernel.Bind<IFeedbackRepository>().To<EFFeedbackRepository>();
            kernel.Bind<IMarkRepository>().To<EFMarkRepository>();
            kernel.Bind<IUserRepository>().To<EFUserRepository>();

        }
    }
}
