using System.Collections.Generic;

namespace SimpleFactoryDemo.Models
{
    public class OnlineStudent : Student
    {
        public const string Type = "Online";

        public OnlineStudent(string name, IList<double> evaluations)
            : base(name, evaluations)
        {
        }
    }
}
