using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder
{
    public class Assistant
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }
        public IList<Course> Courses { get; set; } 

        public Assistant()
        {
            Id = Guid.NewGuid();
            Courses = new List<Course>();
        }
        public override string ToString()
        {
            StringBuilder returnString = new StringBuilder();
            returnString.Append("===============================================");
            returnString.Append(Environment.NewLine);
            returnString.Append($"Asisstant Id: {Id}");
            returnString.Append(Environment.NewLine);
            returnString.Append($"Name: {FirstName} {LastName.ToUpper()}");
            returnString.Append(Environment.NewLine);
            returnString.Append($"Department: {Department.Name}");
            returnString.Append(Environment.NewLine);
            returnString.Append("Courses this assistant teaches: ");
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
