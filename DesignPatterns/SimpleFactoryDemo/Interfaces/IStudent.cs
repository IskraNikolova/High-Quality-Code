namespace SimpleFactoryDemo.Interfaces
{
    using System.Collections.Generic;

    public interface IStudent
    {
        string Name { get; }
        IList<double> Evaluations { get; }
    }
}