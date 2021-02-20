using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<Course> Courses {get;set;}

        public Student()
        {
            Id = Guid.NewGuid();
            Courses = new List<Course>();
        }

        public override string ToString()
        {
            StringBuilder returnString = new StringBuilder();
            returnString.Append("===============================================");
            returnString.Append(Environment.NewLine);
            returnString.Append($"Student Id: {Id}");
            returnString.Append(Environment.NewLine);
            returnString.Append($"Name: {FirstName} {LastName.ToUpper()}");
            returnString.Append(Environment.NewLine);
            returnString.Append("Courses this student enrolled in: ");
            returnString.Append(Environment.NewLine);
            foreach (var course in Courses)
            {
                returnString.Append($"Course title: {course.Name}");
                returnString.Append(Environment.NewLine);
            }
            return returnString.ToString();
        }
    }
}
