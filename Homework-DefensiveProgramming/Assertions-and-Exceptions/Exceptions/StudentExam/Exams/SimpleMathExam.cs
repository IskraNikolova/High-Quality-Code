namespace Exceptions_Homework
{
    public class SimpleMathExam : IExam
    {
        private double problemSolved;

        public SimpleMathExam(double problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public double ProblemsSolved
        {
            get { return this.problemSolved; }
            private set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 10)
                {
                    value = 10;
                }

                this.problemSolved = value;
            }
        }

        public ExamResult Check()
        {
            if (this.ProblemsSolved == 0)
            {
                return new ExamResult(2, 2, 6);
            }
            else if (this.ProblemsSolved == 1)
            {
                return new ExamResult(4, 2, 6);
            }
            else if (this.ProblemsSolved == 2)
            {
                return new ExamResult(6, 2, 6);
            }

            return new ExamResult(0, 0, 0);
        }
    }
}
