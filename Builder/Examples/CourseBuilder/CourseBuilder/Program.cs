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

            Course newCourse = courseBuilder.Course.AddTitle("Intro to computer programming")
                                                .HeldBy("Computer science")
                                                .NumberOfCredits(5)
                                                .NumberOfLectures(24)
                                                .BeginsOn(new DateTime(2021, 2, 25))
                                                .EndsOn(new DateTime(2021, 6, 8))
                                          .Professor.FullName("John", "Smith")
                                                    .PartOf("Computer science")
                                          .Assistants.Join("Jay", "Lee").PartOf("Computer Science")
                                                     .Join("Shawn", "Williams").PartOf("Automatics")
                                                     .Join("Samantha", "West").PartOf("Electrical Engineering")
                                          .Students.Enroll("Mike", "Brown")
                                                   .Enroll("Stuart", "Jones")
                                                   .Enroll("Michelle", "Jan")
                                                   .Enroll("John", "Adams")
                                                   .Enroll("Stanley", "Johnson")
                                                   .Enroll("Janet", "Benn")                                                
                                                   .Enroll(stud);

            var courseBuilder1 = new Builder.CourseBuilder();

            var assistant = newCourse.Assistants.Find(a => a.FirstName == "Jay" && a.LastName == "Lee");

            Course newCourse1 = courseBuilder1.Course.AddTitle("Digital Logic")
                                    .HeldBy("Electrical Engineering")
                                    .NumberOfCredits(3)
                                    .NumberOfLectures(20)
                                    .BeginsOn(new DateTime(2022, 3, 25))
                                    .EndsOn(new DateTime(2022, 7, 8))
                              .Professor.FullName("Mark", "Wod")
                                        .PartOf("Electrical Engineering")
                              .Assistants.Join(assistant)
                                         .Join("Shawn", "Williams").PartOf("Automatics")
                                         .Join("Samantha", "West").PartOf("Electrical Engineering")
                              .Students.Enroll("Mike", "Brown")
                                       .Enroll("Stuart", "Jones")
                                       .Enroll("Michelle", "Jan")
                                       .Enroll("John", "Adams")
                                       .Enroll("Stanley", "Johnson")
                                       .Enroll("Janet", "Benn")
                                       .Enroll(stud);

            Console.WriteLine(newCourse.ToString());
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
