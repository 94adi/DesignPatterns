using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder.Builder
{
    public class CourseBuilder
    {
        protected Course course = new Course();
        
        public static implicit operator Course(CourseBuilder cb) => cb.course;

        public CourseProfessorBuilder Professor => new CourseProfessorBuilder(course);
        public CourseStudentsBuilder Students => new CourseStudentsBuilder(course);
        public CourseAssistantsBuilder Assistants => new CourseAssistantsBuilder(course);
        public CourseBasicInfoBuilder Course => new CourseBasicInfoBuilder(course);

    }
}
