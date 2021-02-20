using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder.Builder
{
    public class CourseBasicInfoBuilder : CourseBuilder
    {
        public CourseBasicInfoBuilder(Course course)
        {
            this.course = course;
        }

        public CourseBasicInfoBuilder AddTitle(string title)
        {
            this.course.Name = title;
            return this;
        }

        public CourseBasicInfoBuilder NumberOfLectures(int count)
        {
            this.course.LecturesCount = count;
            return this;
        }

        public CourseBasicInfoBuilder NumberOfCredits(int count)
        {
            this.course.Credits = count;
            return this;
        }

        public CourseBasicInfoBuilder BeginsOn(DateTime date)
        {
            this.course.StartDate = date;
            return this;
        }

        public CourseBasicInfoBuilder EndsOn(DateTime date)
        {
            this.course.EndDate = date;
            return this;
        }

        public CourseBasicInfoBuilder HeldBy(string departmentName)
        {
            this.course.Department = new Department() { Name = departmentName };
            return this;
        }

        public CourseBasicInfoBuilder HeldBy(Department department)
        {
            this.course.Department = department;
            return this;
        }
    }
}
