using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder.Builder
{
    public class CourseProfessorBuilder : CourseBuilder
    {
        public CourseProfessorBuilder(Course course)
        {
            this.course = course;
            this.course.Professor.Courses.Add(course);
            this.course.Professor.Id = Guid.NewGuid();
        }

        public CourseProfessorBuilder FullName(string firstName, string lastName)
        {
            var professor = new Professor() { FirstName = firstName, LastName = lastName };
            professor.Courses.Add(this.course);
            this.course.Professor = professor;
            return this;
        }

        public CourseProfessorBuilder PartOf(string departmentName)
        {
            this.course.Professor.Department.Name = departmentName;
            return this;
        }

        public CourseProfessorBuilder PartOf(Department depratment)
        {
            this.course.Professor.Department = depratment;
            return this;
        }

    }
}
