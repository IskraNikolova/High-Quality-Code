namespace Exceptions_Homework
{
    using System;

    public class ExamResult
    {
        private double grade;
        private double minGrade;
        private double maxGrade;
        private string comments;

        public ExamResult(double grade, double minGrade, double maxGrade)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
        }

        public double Grade
        {
            get { return this.grade; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Value can not be negative.");
                }

                this.grade = value;
            }
        }

        public double MinGrade
        {
            get { return this.minGrade; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Value can not be negative.");
                }

                this.minGrade = value;
            }
        }

        public double MaxGrade
        {
            get { return this.maxGrade; }
            private set
            {
                if (value <= this.MinGrade)
                {
                    throw new ArgumentOutOfRangeException("Invalid grade!");
                }

                this.maxGrade = value;
            }
        }
    }
}
