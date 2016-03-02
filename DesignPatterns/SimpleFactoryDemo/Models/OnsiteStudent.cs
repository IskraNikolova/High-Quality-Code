namespace SimpleFactoryDemo.Models
{
    using System.Collections.Generic;

    public class OnsiteStudent : Student
    {
        public const int ID = 1;

        public OnsiteStudent(string name, IList<int> evaluations)
            : base(name, evaluations)
        {
        }
    }
}
