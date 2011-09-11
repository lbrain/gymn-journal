﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities;

namespace Domain {
    public interface IStudentRepository {
        IQueryable<Student> Students { get; }
    }
}
