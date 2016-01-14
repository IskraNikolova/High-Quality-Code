namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string name) 
            : base(name)
        {
        }

        public LocalCourse(string courseName, string teacherName) 
            : base(courseName, teacherName)
        {
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students) 
            : base(courseName, teacherName, students)
        {
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students, string lab)
          : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw  new ArgumentNullException(nameof(value), "The name of lab cannot be null or empty.");
                }
                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
         
            if (this.Lab != null)
            {
                result.AppendLine($"Lab = {this.Lab}");
            }

            return base.ToString() + result;
        }
    }
}
