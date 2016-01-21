using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Exceptions_Homework;

public class Student
{
    private string firstName;
    private string lastName;
    private IList<IExam> exams;
     
    public Student(string firstName, string lastName, IList<IExam> exams)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            bool isMatch = IsMatch(value);
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value), "First name can not be empty.");
            }
            else if (!isMatch)
            {
                throw new FormatException("Invalid first name!");
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
            bool isMatch = IsMatch(value);
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value), "Last name can not be empty.");
            }
            else if (!isMatch)
            {
                throw new FormatException("Invalid first name!");
            }

            this.lastName = value;
        }
    }

    private bool IsMatch(string value)
    {
        string pattern = @"\b[A-Z][a-z]+\b";
        Regex regex = new Regex(pattern);
        Match match = regex.Match(value);
        bool isMatch = match.Success;
        return isMatch;
    }

    public IList<IExam> Exams
    {
        get { return this.exams; }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "List of exams can not be null.");
            }

            this.exams = value;
        }
    }

    public IList<ExamResult> CheckExams()
    {
        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                (examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName}";
    }
}
