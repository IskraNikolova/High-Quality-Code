namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    public class CoursesExamples
    {
        public static void Main()
        {
            string localCorseName = "Databases";
            LocalCourse localCourse = new LocalCourse(localCorseName);
            Console.WriteLine(localCourse);

            localCourse.Lab = "Enterprise";
            Console.WriteLine(localCourse);

            localCourse.Students = new List<string>(){ "Peter", "Maria" };
            Console.WriteLine(localCourse);

            localCourse.TeacherName = "Svetlin Nakov";
            localCourse.Students.Add("Milena");
            localCourse.Students.Add("Todor");
            Console.WriteLine(localCourse);

            string courseName = "PHP and WordPress Development";
            string teacherName = "Mario Peshev";
            IList<string> studentsName = new List<string>()
            {
                "Thomas", "Ani", "Steve"
            };

            OffsiteCourse offsiteCourse = new OffsiteCourse(courseName, teacherName, studentsName);
            Console.WriteLine(offsiteCourse);
        }
    }
}
