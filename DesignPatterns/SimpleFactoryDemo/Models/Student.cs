namespace SimpleFactoryDemo.Models
{
    using System.Collections.Generic;
    using SimpleFactoryDemo.Interfaces;

    public abstract class Student : IStudent
    {
        protected Student(string name, IList<int> evaluations)
        {
            this.Name = name;
            this.Evaluations = evaluations;
        }

        public string Name { get; private set; }

        public IList<int> Evaluations { get; private set; }
    }
}
