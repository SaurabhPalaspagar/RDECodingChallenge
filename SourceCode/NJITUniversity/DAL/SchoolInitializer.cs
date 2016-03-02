using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NJITUniversity.Models;

namespace NJITUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Saurabh",LastName="Palaspagar",EnrollmentDate=DateTime.Parse("2016-12-15")},
            new Student{FirstMidName="Pooja",LastName="Deshmuk",EnrollmentDate=DateTime.Parse("2017-12-15")},
            new Student{FirstMidName="Deep",LastName="Kumar",EnrollmentDate=DateTime.Parse("2015-12-15")},
            new Student{FirstMidName="Ashneel",LastName="Sharma",EnrollmentDate=DateTime.Parse("2016-12-15")},
            new Student{FirstMidName="Lu",LastName="Yan",EnrollmentDate=DateTime.Parse("2017-05-15")},
            new Student{FirstMidName="Jay",LastName="Ravaliya",EnrollmentDate=DateTime.Parse("2017-01-15")},
            new Student{FirstMidName="Varun",LastName="Sharma",EnrollmentDate=DateTime.Parse("2016-12-15")},
            new Student{FirstMidName="Oliver",LastName="Queen",EnrollmentDate=DateTime.Parse("2016-12-15")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=610,Title="DSA",Credits=3,},
            new Course{CourseID=631,Title="DBMS",Credits=3,},
            new Course{CourseID=635,Title="IHLP",Credits=3,},
            new Course{CourseID=506,Title="FCS",Credits=4,},
            new Course{CourseID=620,Title="AI",Credits=4,},
            new Course{CourseID=646,Title="Data Mining",Credits=3,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=610,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=506,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=620,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=620,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=610,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=506,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=610},
            new Enrollment{StudentID=4,CourseID=646,},
            new Enrollment{StudentID=4,CourseID=646,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=610,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=620},
            new Enrollment{StudentID=7,CourseID=506,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}