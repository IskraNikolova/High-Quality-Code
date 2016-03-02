namespace SimpleFactoryDemo.Factory
{
    using System;
    using System.Collections.Generic;
    using SimpleFactoryDemo.Interfaces;
    using SimpleFactoryDemo.Models;

    public class SimpleFactory : IFactory
    {
        public IStudent Create(string type, string name, IList<double> evaluations)
        {
            switch (type)
            {
                case OnlineStudent.Type:
                    return new OnlineStudent(name, evaluations);
                case OnsiteStudent.Type:
                    return new OnsiteStudent(name, evaluations);
                case RemoteStudent.Type:
                    return new RemoteStudent(name, evaluations);
            }

            throw new NotImplementedException("Invalid ID");
        }
    }
}
