namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        private string courseName;
        private string teacherName;
     
        protected Course(string courseName)
        {
            this.CourseName = courseName;         
        }

        protected Course(string courseName, string teacherName)
            : this(courseName)
        { 
            this.TeacherName = teacherName;
        }

        protected Course(string courseName, string teacherName, IList<string> students)
            : this(courseName, teacherName)
        {
            this.Students = students;
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Course Name", "The Course name cannot be null empty or whitespace");
                }

                this.courseName = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Teacher's Name", "The Teacher's name cannot be null empty or whitespace");
                }

                this.teacherName = value;
            }
        }

        public IList<string> Students { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.GetType().Name);
            result.AppendLine($"Name = {this.CourseName}");
           
            if (this.TeacherName != null)
            {
                result.AppendLine($"Teacher = {this.TeacherName};");
            }

            if (this.Students != null)
            {
                string formatStudentsNameOfList = "{ " + string.Join(", ", this.Students) + " }";
                result.AppendLine($"Students = {formatStudentsNameOfList};");
            }

            return result.ToString();
        }
    }
}
