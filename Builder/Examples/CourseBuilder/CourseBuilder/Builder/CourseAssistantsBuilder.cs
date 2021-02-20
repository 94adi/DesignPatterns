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
            this.course.Assistants.Add(new Assistant { FirstName = firstName, LastName = lastName });
            var lastElement = this.course.Assistants.Count - 1;
            this.course.Assistants[lastElement].Courses.Add(this.course);
            return this;
        }

        public CourseAssistantsBuilder Join(Assistant assistant)
        {
            course.Assistants.Add(assistant);
            var lastElement = this.course.Assistants.Count - 1;
            this.course.Assistants[lastElement].Courses.Add(this.course);
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
