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
            this.course.Students.Add(new Student() { FirstName = firstName, LastName = lastName });
            var lastIndex = this.course.Students.Count;
            this.course.Students[lastIndex - 1].Courses.Add(this.course);
            return this;
        }
        public CourseStudentsBuilder Enroll(Student student)
        {
            this.course.Students.Add(student);
            var lastIndex = this.course.Students.Count;
            this.course.Students[lastIndex - 1].Courses.Add(this.course);
            return this;
        }
    }
}
