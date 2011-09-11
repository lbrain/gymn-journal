using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Moq;
using Domain.Entities;
using Domain.Concrete;

namespace Domain.Infrastructure {
    public class NinjectControllerFactory : DefaultControllerFactory {
        private IKernel ninjectKernel;

        public NinjectControllerFactory() {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType) {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings() {
            ninjectKernel.Bind<IStudentRepository>().To<EFStudentRepository>();
        }
    }
}
