namespace SimpleFactoryDemo.Models
{
    using System.Collections.Generic;

    public class OnsiteStudent : Student
    {
        public const string Type = "Onsite";

        public OnsiteStudent(string name, IList<double> evaluations)
            : base(name, evaluations)
        {
        }
    }
}
