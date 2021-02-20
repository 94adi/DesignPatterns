using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int LecturesCount { get; set; }
        public int Credits { get; set; }
        public Department Department { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public Professor Professor { get; set; } = new Professor();
        public List<Assistant> Assistants { get; set; } = new List<Assistant>();

        public Course()
        {
            Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            StringBuilder returnString = new StringBuilder();
            returnString.Append($"Course ID: {Id}");
            returnString.Append(Environment.NewLine);

            returnString.Append($"Name: {Name}  || Number of lectures: {LecturesCount} || Credits: {Credits}");
            returnString.Append(Environment.NewLine);

            returnString.Append($"Begins on: {StartDate.ToString("dd/MM/yyyy")} || Ends on: {EndDate.Date.ToString("dd/MM/yyyy")}");
            returnString.Append(Environment.NewLine);

            returnString.Append($"Department ID: {Department.Id} || Name: {Department.Name}");
            returnString.Append(Environment.NewLine);

            returnString.Append($"Course instructor: {Professor.FirstName} {Professor.LastName.ToUpper()}");
            returnString.Append(Environment.NewLine);

            returnString.Append($"Teaching Assistants:");
            returnString.Append(Environment.NewLine);

            foreach (var assistant in Assistants)
            {
                returnString.Append(assistant.ToString());
                returnString.Append(Environment.NewLine);
            }

            returnString.Append($"Enrolled students:");

            foreach (var student in Students)
            {
                returnString.Append(Environment.NewLine);
                returnString.Append(student.ToString());

            }

            returnString.Append(Environment.NewLine);
            returnString.Append($"Course start date:{StartDate.ToString()}");
            returnString.Append($"Course end date:{EndDate.ToString()}");

            return returnString.ToString();
        }
    }
}
