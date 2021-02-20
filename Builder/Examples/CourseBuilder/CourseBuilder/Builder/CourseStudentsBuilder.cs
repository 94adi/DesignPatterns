using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder.Builder
{
    public class CourseStudentsBuilder : CourseBuilder
    {
        public CourseStudentsBuilder(Course course)
        {
            this.course = course;
        }

        public CourseStudentsBuilder Enroll(string firstName, string lastName)
        {
            var student = new Student() { FirstName = firstName, LastName = lastName };
            student.Courses.Add(this.course);
            this.course.Students.Add(student);
            return this;
        }
        public CourseStudentsBuilder Enroll(Student student)
        {
            student.Courses.Add(this.course);
            this.course.Students.Add(student);
            return this;
        }
    }
}
