namespace SimpleFactoryDemo.Models
{
    using System.Collections.Generic;
    using SimpleFactoryDemo.Interfaces;

    public abstract class Student : IStudent
    {
        protected Student(string name, IList<double> evaluations)
        {
            this.Name = name;
            this.Evaluations = evaluations;
        }

        public string Name { get; private set; }

        public IList<double> Evaluations { get; private set; }
    }
}
