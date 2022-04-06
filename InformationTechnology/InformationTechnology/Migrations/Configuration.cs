namespace InformationTechnology.Migrations
{
    using System.Collections.Generic;
    using InformationTechnology.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InformationTechnology.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "InformationTechnology.Models.ApplicationDbContext";
        }

        protected override void Seed(InformationTechnology.Models.ApplicationDbContext context)
        {
            /*
            var courses = new List<Course>()
            {
                new Course { CourseID = 1, CourseName = "Computer Science", TeacherName= "Mr Andrew, Mr Michal, Dr Drew", CourseDescription= "This course is an introduction to computers and computer science for non - computer science majors.Prior experience with computers, such as using a graphical user interface and a word processor, is recommended.Students with no prior experience will be expected to attend out-of-class labs to learn the basics of a computer.Topics include an historical perspective, evolving hardware and software, using the Internet, creating web pages, social implications, and using a modern programming language.Problem solving and algorithm development are important themes of the class. The course involves substantial use of microcomputers outside of class and the possible use of minicomputers and alternative operating systems."},
                new Course { CourseID = 2, CourseName = "Software Engineering", TeacherName = "Mr Andrew, Ms Charlotte", CourseDescription= "Software engineering is the branch of computer science that creates practical, cost-effective solutions to computing and information processing problems, preferentially by applying scientific knowledge, developing software systems in the service of mankind.  This course covers the fundamentals of software engineering, including understanding system requirements, finding appropriate engineering compromises, effective methods of design, coding, and testing, team software development, and the application of engineering tools.  The course will combine a strong technical focus with a capstone project providing the opportunity to practice engineering knowledge, skills, and practices in a realistic development setting with a real client."},
                new Course { CourseID = 3, CourseName = "Cyber Security", TeacherName="Mr Michal, Mr Kieran", CourseDescription= "This course introduces the concepts and understanding of the field of computer security and how it relates to other areas of information technology. Topics include security threats, hardening systems, securing networks, cryptography and organizational security policies."}
            };
            
            courses.ForEach(course => context.Courses.AddOrUpdate(p => p.CourseID, course));
            context.SaveChanges();
            */
            //The INSERT statement conflicted with the FOREIGN KEY constraint "FK_dbo.Modules_dbo.Courses_CourseID". The conflict occurred in database "aspnet-InformationTechnology-ce56d88a-1eec-43af-8de6-753bb04a83be", table "dbo.Courses", column 'CourseID'.
            /*
            var modules = new List<Module>()
            {
                new Module { ModuleID = 1,
                ModuleTitle = "Scala Programming",
                ModuleCode = "COS1903",
                CourseID = 13 },


                new Module {
                ModuleID = 2,
                ModuleTitle = "Database Management",
                ModuleCode = "COS1920",
                CourseID = 13 },

                new Module {ModuleID = 3,
                ModuleTitle = "Object Oriented Programming (Java)",
                ModuleCode = "COS2905",
                CourseID = 13},

                new Module {ModuleID = 4,
                ModuleTitle = "Database Management",
                ModuleCode = "COS2910",
                CourseID = 13},

                new Module {ModuleID = 5,
                ModuleTitle = "Mobile Application",
                ModuleCode = "COS3911",
                CourseID = 13 },

                new Module {ModuleID = 6,
                ModuleTitle = "Computer Ethics and Privacy",
                ModuleCode = "IMAT3611",
                CourseID = 13},

                new Module  {ModuleID = 7,
                ModuleTitle = "Development Project",
                ModuleCode = "COS3451",
                CourseID = 13}

            };
            modules.ForEach(module => context.Modules.AddOrUpdate(m => m.ModuleID, module));
            context.SaveChanges();
            */
        }
    }
}
