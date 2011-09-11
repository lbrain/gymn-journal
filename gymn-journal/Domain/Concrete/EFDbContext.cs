using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Domain.Entities;

namespace Domain.Concrete {
    public class EFDbContext : DbContext {
        public DbSet<Student> Students { get; set; }
    }
}
