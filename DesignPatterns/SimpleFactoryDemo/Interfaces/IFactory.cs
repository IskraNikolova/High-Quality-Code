using System.Collections.Generic;

namespace SimpleFactoryDemo.Interfaces
{
    public interface IFactory
    {
        IStudent Create(string type, string name, IList<double> evaluations);
    }
}