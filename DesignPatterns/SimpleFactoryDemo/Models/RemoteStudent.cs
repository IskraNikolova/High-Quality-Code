namespace SimpleFactoryDemo.Models
{
    using System.Collections.Generic;

    public class RemoteStudent : Student
    {
        public const string Type = "RemoteStudent";

        public RemoteStudent(string name, IList<double> evaluations) 
            : base(name, evaluations)
        {
        }
    }
}
