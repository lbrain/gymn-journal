using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Entities {
    class Student {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
    }
}
