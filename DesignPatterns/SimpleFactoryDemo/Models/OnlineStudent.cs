using System.Collections.Generic;

namespace SimpleFactoryDemo.Models
{
    public class OnlineStudent : Student
    {
        public const int ID = 2;

        public OnlineStudent(string name, IList<int> evaluations)
            : base(name, evaluations)
        {
        }
    }
}
