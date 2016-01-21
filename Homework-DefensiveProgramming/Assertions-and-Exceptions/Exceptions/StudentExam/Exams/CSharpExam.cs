using System;
using Exceptions_Homework;

public class CSharpExam : IExam
{
    private double score;

    public CSharpExam(double score)
    {
        this.Score = score;
    }

    public double Score
    {
        get { return this.score; }
        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Score must be in range [0...100].");
            }

            this.score = value;
        }
    }

    public ExamResult Check()
    {
         return new ExamResult(this.Score, 0, 100);
    }
}
