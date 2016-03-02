namespace SimpleFactoryDemo.Models
{
    using System.Collections.Generic;

    public class RemoteStudent : Student
    {
        public const int ID = 3;

        public RemoteStudent(string name, IList<int> evaluations) 
            : base(name, evaluations)
        {
        }
    }
}
