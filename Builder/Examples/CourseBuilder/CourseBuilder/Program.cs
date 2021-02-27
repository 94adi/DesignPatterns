using System;
using System.Collections.Generic;
using CourseBuilder.Builder;
namespace CourseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //taken from data source
            Student stud = new Student()
            {
                Id = new Guid("df0d0294-90ad-44cd-a548-ad7b30954e5e"),
                FirstName = "John",
                LastName = "Overland"
            };

            var courseBuilder = new Builder.CourseBuilder();
            var courseBuilder1 = new Builder.CourseBuilder();

            Course myCourse = courseBuilder.AddTitle("Intro to computer programming")
                                           .NumberOfLectures(24)
                                           .NumberOfCredits(4)
                                           .HeldBy("Computer science")
                                           .BeginsOn(new DateTime(2021, 2, 25))
                                           .EndsOn(new DateTime(2021, 6, 8))
                                           .AddProfessor("John", "Smith", "Computer science")
                                           .AddAssistant("Jay", "Lee", "Computer Science")
                                           .AddAssistant("Shawn", "Williams", "Automatics")
                                           .AddAssistant("Samantha", "West", "Electrical Engineering")
                                           .EnrollStudent("Stuart", "Jones")
                                           .EnrollStudent("Michelle", "Jan")
                                           .EnrollStudent("John", "Adams")
                                           .EnrollStudent("Stanley", "Johnson")
                                           .EnrollStudent("Janet", "Benn")
                                           .EnrollStudent(stud)
                                           .Build();

            Course myCourse1 = courseBuilder1.AddTitle("Digital Logic")
                               .NumberOfLectures(24)
                               .NumberOfCredits(4)
                               .HeldBy("Computer science")
                               .BeginsOn(new DateTime(2021, 2, 25))
                               .EndsOn(new DateTime(2021, 6, 8))
                               .AddProfessor("John", "Smith", "Computer science")
                               .AddAssistant("Jay", "Lee", "Computer Science")
                               .AddAssistant("Shawn", "Williams", "Automatics")
                               .AddAssistant("Samantha", "West", "Electrical Engineering")
                               .EnrollStudent("Stuart", "Jones")
                               .EnrollStudent("Michelle", "Jan")
                               .EnrollStudent("John", "Adams")
                               .EnrollStudent("Stanley", "Johnson")
                               .EnrollStudent("Janet", "Benn")
                               .EnrollStudent(stud)
                               .Build();

            Console.WriteLine(myCourse.ToString());
            #region BAD_EXAMPLE
            /*Course courseBad = new Course()
            {
                Id = Guid.NewGuid(),
                Name = "Data structures and algorithms",
                LecturesCount = 12,
                Credits = 4,
                Department = new Department { Id = Guid.NewGuid(), Name = "Computer Science" },
                StartDate = new DateTime(2021, 2, 2),
                EndDate = new DateTime(2021, 6, 4),
                Students = new List<Student>()
                {
                    new Student{Id = Guid.NewGuid(), Name = "John Smith"},
                    new Student{Id = Guid.NewGuid(), Name = "Jane Doe"},
                    new Student{Id = Guid.NewGuid(), Name = "Steve Wilson"},
                },
                Professor = new Professor() { Id = Guid.NewGuid(), FirstName = "William", LastName = "Wol", Department = new Department { Id = Guid.NewGuid(), Name = "Computer Science" } },
                Assistants = new List<Assistant>() { }
            };

            Console.WriteLine(course.ToString());*/

            #endregion

            Console.ReadLine();
        }
    }
}
