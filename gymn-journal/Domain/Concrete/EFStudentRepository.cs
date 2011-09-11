using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities;

namespace Domain.Concrete {
    public class EFStudentRepository : IStudentRepository {
        private EFDbContext context = new EFDbContext();
        public IQueryable<Student> Students {
            get { return context.Students; }
        }
    }
}
