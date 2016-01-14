using System;
using System.Globalization;

namespace Methods
{
    public class Student
    {
        private string firstName;
        private string lastName;

        public Student(string firstName, string lastName, string otherInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.OtherInfo = otherInfo;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "First name cannot be empty.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "Last name cannot be empty.");
                }

                this.lastName = value;
            }
        }
        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            string firstDateString = this.OtherInfo.Substring(this.OtherInfo.Length - 10);
            string secondDateString = other.OtherInfo.Substring(other.OtherInfo.Length - 10);
            DateTime firstDate = DateTime.ParseExact(firstDateString, "dd.MM.yyyy", CultureInfo.InvariantCulture);         
            DateTime secondDate = DateTime.ParseExact(secondDateString, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            bool isOlder = firstDate > secondDate;

            return isOlder;       
        }
    }
}
