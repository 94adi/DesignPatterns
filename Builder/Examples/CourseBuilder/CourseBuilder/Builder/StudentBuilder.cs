using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder.Builder
{
    public static class StudentBuilder
    {

        public static Student Build(string firstName, string lastName)
        {
            var student = new Student() {Id = Guid.NewGuid(), FirstName = firstName, LastName = lastName };
            return student;
        }

    }
}
