using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Moq;
using Domain.Entities;

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
            Mock<IStudentRepository> mock = new Mock<IStudentRepository>();
            mock.Setup(m => m.Students).Returns(new List<Student> {
                new Student { Name = "A1", Surname = "B1", Patronymic = "C1", Class = "1a" },
                new Student { Name = "A2", Surname = "B2", Patronymic = "C2", Class = "1a" },
                new Student { Name = "A3", Surname = "B3", Patronymic = "C3", Class = "1a" },
                new Student { Name = "A4", Surname = "B4", Patronymic = "C4", Class = "1a" },
                new Student { Name = "A5", Surname = "B5", Patronymic = "C5", Class = "2a" },
                new Student { Name = "A6", Surname = "B6", Patronymic = "C6", Class = "2a" },
                new Student { Name = "A7", Surname = "B7", Patronymic = "C7", Class = "2a" },
                new Student { Name = "A8", Surname = "B8", Patronymic = "C8", Class = "2a" },
                new Student { Name = "A9", Surname = "B9", Patronymic = "C9", Class = "3a" },
                new Student { Name = "A10", Surname = "B10", Patronymic = "C10", Class = "3a" }
            }.AsQueryable());

            ninjectKernel.Bind<IStudentRepository>().ToConstant(mock.Object);
        }
    }
}
