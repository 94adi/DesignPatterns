using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder.Builder
{
    public static class ProfessorBuilder
    {

        public static Professor Build(string firstName, string lastName, string department)
        {
            var proffesor = new Professor()
            {
                Id = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
                Department = new Department { Id = Guid.NewGuid(), Name = department}
            };

            return proffesor;
        }

        public static Professor Build(string firstName, string lastName, Department department)
        {
            var proffesor = new Professor()
            {
                Id = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
                Department = department
            };

            return proffesor;
        }
    }
}
