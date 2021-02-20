using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder.Builder
{
    public class CourseAssistantsBuilder : CourseBuilder
    {

        public CourseAssistantsBuilder(Course course)
        {
            this.course = course;
        }

        public CourseAssistantsBuilder Join(string firstName, string lastName)
        {
            var assistant = new Assistant() { FirstName = firstName, LastName = lastName };
            assistant.Courses.Add(this.course);
            this.course.Assistants.Add(assistant);
            return this;
        }

        public CourseAssistantsBuilder Join(Assistant assistant)
        {
            assistant.Courses.Add(this.course);
            course.Assistants.Add(assistant);
            return this;
        }

        public CourseAssistantsBuilder PartOf(string departmentName)
        {
            var lastElement = course.Assistants.Count - 1;
            var assistant = course.Assistants[lastElement];
            assistant.Department = new Department() { Name = departmentName };
            return this;
        }

        public CourseAssistantsBuilder PartOf(Department department)
        {
            var lastElement = course.Assistants.Count - 1;
            var assistant = course.Assistants[lastElement];
            assistant.Department = department;
            return this;
        }
    }
}
