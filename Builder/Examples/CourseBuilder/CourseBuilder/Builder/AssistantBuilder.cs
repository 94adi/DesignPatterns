using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder.Builder
{
    public static class AssistantBuilder
    {

        public static Assistant Build(string firstName, string lastName, string department)
        {
            var assistant = new Assistant() {
                Id = Guid.NewGuid(), 
                FirstName = firstName, 
                LastName = lastName,
                Department = new Department() { Id = Guid.NewGuid(), Name = department }
            };

            return assistant;
        }

        public static Assistant Build(string firstName, string lastName, Department department)
        {
            var assistant = new Assistant()
            {
                Id = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
                Department = department
            };

            return assistant;
        }
    }
}
