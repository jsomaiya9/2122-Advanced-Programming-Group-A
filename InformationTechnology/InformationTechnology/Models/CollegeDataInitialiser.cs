using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace InformationTechnology.Models
{
    public class CollegeDataInitialiser : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            //Course 1 
            Course Course1 = new Course();
            Course1.CourseID = 1;
            Course1.CourseName = "Computer Science";
            Course1.TeacherName = "Mr Andrew, Mr Michal, Dr Drew";
            Course1.CourseDescription = "This course is an introduction to computers and computer science for non - computer science majors.Prior experience with computers, such as using a graphical user interface and a word processor, is recommended.Students with no prior experience will be expected to attend out-of-class labs to learn the basics of a computer.Topics include an historical perspective, evolving hardware and software, using the Internet, creating web pages, social implications, and using a modern programming language.Problem solving and algorithm development are important themes of the class. The course involves substantial use of microcomputers outside of class and the possible use of minicomputers and alternative operating systems.";
            context.Courses.Add(Course1);

            //Course 2
            Course Course2 = new Course();
            Course2.CourseID = 2;
            Course2.CourseName = "Software Engineering";
            Course2.CourseDescription = "Software engineering is the branch of computer science that creates practical, cost-effective solutions to computing and information processing problems, preferentially by applying scientific knowledge, developing software systems in the service of mankind.  This course covers the fundamentals of software engineering, including understanding system requirements, finding appropriate engineering compromises, effective methods of design, coding, and testing, team software development, and the application of engineering tools.  The course will combine a strong technical focus with a capstone project providing the opportunity to practice engineering knowledge, skills, and practices in a realistic development setting with a real client.";
            Course2.TeacherName = "Mr Andrew, Ms Charlotte, Mr Ethan, Mr Degree ";
            context.Courses.Add(Course2);

            //Course 3 
            Course Course3 = new Course();
            Course3.CourseID = 3;
            Course3.CourseName = "Cyber Security";
            Course3.CourseDescription = "This course introduces the concepts and understanding of the field of computer security and how it relates to other areas of information technology. Topics include security threats, hardening systems, securing networks, cryptography and organizational security policies.";
            Course3.TeacherName = "Mr Michal, Mr Kieran, Mr Oliver, Ms Fortune";
            context.Courses.Add(Course3);

            
            //Modules
            
            //Modules for course1
            //Module 1 
            Module module1 = new Module();
            module1.ModuleID = 1;
            module1.ModuleTitle = "Scala Programming";
            module1.ModuleCode = "COS1903";
            module1.ModuleDescription = "Scala is a strong statically typed general-purpose programming language which supports both object-oriented programming and functional programming. Designed to be concise, many of Scala's design decisions are aimed to address criticisms of Java.";
            module1.ModuleTeacher = "Mr Andrew";
            module1.CourseID = 1;
            context.Modules.Add(module1);

            //Module 2
            Module module2 = new Module();
            module2.ModuleID = 2;
            module2.ModuleTitle = "Database Management";
            module2.ModuleCode = "COS1920";
            module2.ModuleDescription = "This module provides an introduction to the theory and practice of database systems. It extends the study of information systems in Stage 1 by focusing on the design, implementation and use of database systems. Topics include database management systems architecture, data modelling and database design, query languages, recent developments and future prospects.";
            module2.ModuleTeacher = "Mr Michal";
            module2.CourseID = 1;
            context.Modules.Add(module2);

            //Module 3
            Module module3 = new Module();
            module3.ModuleID = 3;
            module3.ModuleCode = "COS2905";
            module3.ModuleTitle = "Object Oriented Programmign (Java)";
            module3.ModuleDescription = "The main ideas behind Java's Object-Oriented Programming, OOP concepts include abstraction, encapsulation, inheritance and polymorphism. Basically, Java OOP concepts let us create working methods and variables, then re-use all or part of them without compromising security";
            module3.ModuleTeacher = "Mr Michal";
            module3.CourseID = 1;
            context.Modules.Add(module3);

            //module 4
            Module module4 = new Module();
            module4.ModuleID = 4;
            module4.ModuleCode = "COS2910";
            module4.ModuleTitle = "Database Management";
            module4.ModuleDescription = "This module provides an introduction to the theory and practice of database systems. It extends the study of information systems in Stage 1 by focusing on the design, implementation and use of database systems.";
            module4.ModuleTeacher = "Dr Drew";
            module4.CourseID = 1;
            context.Modules.Add(module4);

            //Module 5
            Module module5 = new Module();
            module5.ModuleID = 5;
            module5.ModuleCode = "COS3911";
            module5.ModuleTitle = "Mobile Application";
            module5.ModuleDescription = "This course is concerned with the design, implementation and testing of applications for the Android Platform. Students will work at all stages of the development life-cycle from inception to testing, whilst considering usability and device capabilities for a mobile application capable of meeting a functional specification.";
            module5.ModuleTeacher = "Dr Drew";
            module5.CourseID = 1;
            context.Modules.Add(module5);

            //Module 6
            Module module6 = new Module();
            module6.ModuleID = 6;
            module6.ModuleCode = "IMAT3611";
            module6.ModuleTitle = "Computer Ethics and Privacy";
            module6.ModuleDescription = "Computer ethics are a set of moral standards that govern the use of computers.  It is society’s views about the use of computers, both hardware and software.  Privacy concerns, intellectual property rights and effects on society are some of the common issues of computer ethics.";
            module6.ModuleTeacher = "Ms Charlotte";
            module6.CourseID = 1;
            context.Modules.Add(module6);

            //Module 7
            Module module7 = new Module();
            module7.ModuleID = 7;
            module7.ModuleCode = "COS3451";
            module7.ModuleTitle = "Development Project";
            module7.ModuleDescription = "This is a skill based course that is primarily designed to provide students with practical skills they are likely to use in development contexts. The course introduces students to the planning and analysis of small scale development projects.";
            module7.ModuleTeacher = "Mr Michal";
            module7.CourseID = 1;
            context.Modules.Add(module7);

            

            
            //Modules for course 2

            //Module 8 
            Module module8 = new Module();
            module8.ModuleID = 8;
            module8.ModuleCode = "SE3906";
            module8.ModuleTitle = "Interaction Design";
            module8.ModuleDescription = "This module provides you with knowledge and methods from the field of Human-Computer Interaction (HCI) about how to better design computer systems for use by humans. This module complements other, more programming intensive modules by providing theory and techniques which will help you to design more usable computer systems. ";
            module8.ModuleTeacher = "Mr Ethan";
            module8.CourseID = 2;
            context.Modules.Add(module8);


            //Module 9
            Module module9 = new Module();
            module9.ModuleID = 9;
            module9.ModuleCode = "SE3410";
            module9.ModuleTitle = "Web Application Penetration Testing";
            module9.ModuleDescription = "Web applications play a vital role in every modern organization. But, if your organization does not properly test and secure its web apps, adversaries can compromise these applications, damage business functionality, and steal data. ";
            module9.ModuleTeacher = "Mr Degree";
            module9.CourseID = 2;
            context.Modules.Add(module9);

            //Module 10
            Module module10 = new Module();
            module10.ModuleID = 10;
            module10.ModuleCode = "SE3406";
            module10.ModuleTitle = "Fuzzy Logic & Knowledge Based Systems";
            module10.ModuleDescription = "The new product development (PD) phase of automotive vehicles in particular and of any complex product in general is a process that requires effective use of knowledge and experience generated from the past. It also involves a large amount of uncertainty which is very difficult to incorporate in well established methodologies and techniques such as quality tools without a large number of assumptions.";
            module9.ModuleTeacher = "Ms Charlotte";
            module10.CourseID = 2;
            context.Modules.Add(module10);

            //Module 11
            Module module11 = new Module();
            module11.ModuleID = 11;
            module11.ModuleCode = "SE3613";
            module11.ModuleTitle = "Data Mining";
            module11.ModuleDescription = "Data mining is a process of extracting, from a large amount of data, interesting patterns that are non-trivial, hidden, new and potentially useful. It is a rapidly growing field and is becoming important because with the increasing quantity and variety of online data collections by many organizations and commercial enterprises, there is a high potential value of patterns discovered in those collections.";
            module11.ModuleTeacher = "Mr Ethan";
            module11.CourseID = 2;
            context.Modules.Add(module11);


            //Module 12
            Module module12 = new Module();
            module12.ModuleID = 12;
            module12.ModuleCode = "SE3614";
            module12.ModuleTitle = "Big Data & Business Models";
            module12.ModuleDescription = "Systems must be architected right from the beginning. A strong architecture leads to a strong foundation and should be applied consistently throughout the entire system.";
            module12.ModuleTeacher = "Mr Ethan";
            module12.CourseID = 2;
            context.Modules.Add(module12);

            //Module 13
            Module module13 = new Module();
            module13.ModuleID = 13;
            module13.ModuleCode = "IMAT3611";
            module13.ModuleTitle = "Computer Ethics and Privacy";
            module13.ModuleDescription = "Computer ethics are a set of moral standards that govern the use of computers.  It is society’s views about the use of computers, both hardware and software.  Privacy concerns, intellectual property rights and effects on society are some of the common issues of computer ethics.";
            module13.ModuleTeacher = "Ms Charlotte";
            module13.CourseID = 2;
            context.Modules.Add(module13);

            //Module 14
            Module module14 = new Module();
            module14.ModuleID = 14;
            module14.ModuleCode = "SE3451";
            module14.ModuleTitle = "Development Project";
            module14.ModuleDescription = "This is a skill based course that is primarily designed to provide students with practical skills they are likely to use in development contexts. The course introduces students to the planning and analysis of small scale development projects.";
            module14.ModuleTeacher = "Mr Michal";
            module14.CourseID = 2;
            context.Modules.Add(module14);
            
            //Modules for Course 3


            //Module 15
            Module module15 = new Module();
            module15.ModuleID = 15;
            module15.ModuleCode = "SE3901";
            module15.ModuleTitle = "C Programming";
            module15.ModuleDescription = "An introduction to designing, writing and testing computer programs using the C Programming language.";
            module15.ModuleTeacher = "Mr Michal";
            module15.CourseID = 3;
            context.Modules.Add(module15);
            
            //Module 16 
            Module module16 = new Module();
            module16.ModuleID = 16;
            module16.ModuleCode = "SE3410";
            module16.ModuleTitle = "Computer Law and Cyber Security Management";
            module16.ModuleDescription = "Covers four broad topic areas: programming, operating systems, encryption and networks. This module prepares the ground for other more tightly focused modules covering closely related topics.";
            module16.ModuleTeacher = "Mr Kieran";
            module16.CourseID = 3;
            context.Modules.Add(module16);

            //Module 17
            Module module17 = new Module();
            module17.ModuleID = 17;
            module17.ModuleCode = "SE3903";
            module17.ModuleTitle = "Linux Security";
            module17.ModuleDescription = "Security. From its very inception, security has been a cornerstone of the Linux operating system. Each user has to be walled off from others, and a password and user ID are required for an individual to use Linux.";
            module17.ModuleTeacher = "Mr Oliver";
            module17.CourseID = 3;
            context.Modules.Add(module17);
           
            //Module 18
            Module module18 = new Module();
            module18.ModuleID = 18;
            module18.ModuleCode = "SE3904";
            module18.ModuleTitle = "Cyber Threat Intelligence and Incident Response";
            module18.ModuleDescription = "Digital technologies lie at the heart of nearly every industry today. The automation and greater connectedness they afford have revolutionized the world’s economic and cultural institutions — but they’ve also brought risk in the form of cyberattacks. Threat intelligence is knowledge that allows you to prevent or mitigate those attacks.";
            module18.ModuleTeacher = "Ms Fortune";
            module18.CourseID = 3;
            context.Modules.Add(module18);

            //Module 19
            Module module19 = new Module();
            module19.ModuleID = 19;
            module19.ModuleCode = "SE3905";
            module19.ModuleTitle = "Malware Analysis";
            module19.ModuleDescription = " Malware analysis is the process of understanding the behavior and purpose of a suspicious file or URL. The output of the analysis aids in the detection and mitigation of the potential threat.";
            module19.ModuleTeacher = "Mr Oliver";
            module19.CourseID = 3;
            context.Modules.Add(module19);


            //Module 20
            Module module20 = new Module();
            module20.ModuleID = 20;
            module20.ModuleCode = "IMAT3611";
            module20.ModuleTitle = "Computer Ethics and Privacy";
            module20.ModuleDescription = "Computer ethics are a set of moral standards that govern the use of computers.  It is society’s views about the use of computers, both hardware and software.  Privacy concerns, intellectual property rights and effects on society are some of the common issues of computer ethics.";
            module20.ModuleTeacher = "Ms Charlotte";
            module20.CourseID = 3;
            context.Modules.Add(module20);

            //Module 21
            Module module21 = new Module();
            module21.ModuleID = 21;
            module21.ModuleCode = "SE3451";
            module21.ModuleTitle = "Development Project";
            module21.ModuleDescription = "This is a skill based course that is primarily designed to provide students with practical skills they are likely to use in development contexts. The course introduces students to the planning and analysis of small scale development projects.";
            module21.ModuleTeacher = "Mr Michal";
            module21.CourseID = 3;
            context.Modules.Add(module21);
                        
        }


    }
}