using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder.Builder
{
    public class CourseBuilder
    {
        protected Course course = new Course();      

        public CourseBuilder EnrollStudent(string firstName, string lastName)
        {
            var student = StudentBuilder.Build(firstName, lastName);
            student.Courses.Add(this.course);
            course.Students.Add(student);
            return this;
        }

        //overloading EnrollStudent method where it takes Student type parameter
        //in this case there's no need for a student object builder
        public CourseBuilder EnrollStudent(Student student)
        {
            student.Courses.Add(this.course);
            course.Students.Add(student);
            return this;
        }

        public CourseBuilder AddProfessor(string firstName, string lastName, string department)
        {
            var professor = ProfessorBuilder.Build(firstName, lastName, department);
            professor.Courses.Add(this.course);
            this.course.Professor = professor;
            return this;
        }

        public CourseBuilder AddProfessor(Professor professor)
        {
            professor.Courses.Add(this.course);
            this.course.Professor = professor;
            return this;
        }

        public CourseBuilder AddProfessor(string firstName, string lastName, Department department)
        {
            var professor = ProfessorBuilder.Build(firstName, lastName, department);
            professor.Courses.Add(this.course);
            this.course.Professor = professor;
            return this;
        }

        public CourseBuilder AddAssistant(string firstName, string lastName, string department)
        {
            var assistant = AssistantBuilder.Build(firstName, lastName, department);
            assistant.Courses.Add(this.course);
            this.course.Assistants.Add(assistant);
            return this;
        }

        public CourseBuilder AddAssistant(string firstName, string lastName, Department department)
        {
            var assistant = AssistantBuilder.Build(firstName, lastName, department);
            assistant.Courses.Add(this.course);
            this.course.Assistants.Add(assistant);
            return this;
        }

        public CourseBuilder AddAssistant(Assistant assistant)
        {
            assistant.Courses.Add(this.course);
            this.course.Assistants.Add(assistant);
            return this;
        }

        public CourseBuilder AddTitle(string title)
        {
            this.course.Name = title;
            return this;
        }

        public CourseBuilder NumberOfLectures(int count)
        {
            this.course.LecturesCount = count;
            return this;
        }

        public CourseBuilder NumberOfCredits(int count)
        {
            this.course.Credits = count;
            return this;
        }

        public CourseBuilder BeginsOn(DateTime date)
        {
            this.course.StartDate = date;
            return this;
        }

        public CourseBuilder EndsOn(DateTime date)
        {
            this.course.EndDate = date;
            return this;
        }

        public CourseBuilder HeldBy(string departmentName)
        {
            this.course.Department = new Department() {Id = Guid.NewGuid(), Name = departmentName };
            return this;
        }

        public CourseBuilder HeldBy(Department department)
        {
            this.course.Department = department;
            return this;
        }

        public Course Build() => course;
    }
}
