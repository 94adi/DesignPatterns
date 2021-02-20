using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder
{
    public class Department
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Department()
        {
            Id = Guid.NewGuid();
        }
    }
}
