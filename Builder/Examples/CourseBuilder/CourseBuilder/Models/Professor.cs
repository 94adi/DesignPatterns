using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder
{
    public class Professor
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }
        public List<Course> Courses { get; set; } 
        public Professor()
        {
            Courses = new List<Course>();
            Id = Guid.NewGuid();
            Department = new Department();
        }

        public override string ToString()
        {
            return $"Guid: {Id} \n Name:{FirstName} {LastName.ToUpper()} \n Department: {Department.Name}";
        }
    }
}
