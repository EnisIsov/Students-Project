namespace StudentsProject.Migrations
{
    using StudentsProject.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentsProject.DataAccessLayer.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StudentsProject.DataAccessLayer.StudentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Subjects.Add(new Subject { Name = "Math", Semester = 1, Credits = 6 });
            context.Subjects.Add(new Subject { Name = "OOP", Semester = 1, Credits = 4 });
            context.Subjects.Add(new Subject { Name = "Internet Technologies", Semester = 2, Credits = 4 });
            context.Subjects.Add(new Subject { Name = "Micro-processors", Semester = 2, Credits = 8 });
            context.Subjects.Add(new Subject { Name = "Data Communication", Semester = 3, Credits = 4 });
            context.Subjects.Add(new Subject { Name = "C#", Semester = 3, Credits = 8 });
            context.Subjects.Add(new Subject { Name = "Java", Semester = 4, Credits = 4 });
            context.Subjects.Add(new Subject { Name = "C++", Semester = 5, Credits = 6 });
            context.Subjects.Add(new Subject { Name = "Algebra", Semester = 6, Credits = 6 });
            context.Subjects.Add(new Subject { Name = "3D programming", Semester = 7, Credits = 8 });
            context.Subjects.Add(new Subject { Name = "Kalkulus", Semester = 8, Credits = 6 });
        }
    }
}
