namespace SimpleFactoryDemo.Factory
{
    using System;
    using System.Collections.Generic;
    using SimpleFactoryDemo.Interfaces;
    using SimpleFactoryDemo.Models;

    public static class SimpleFactory
    {
        public static IStudent Create(int id, string name, IList<int> evaluations)
        {
            switch (id)
            {
                case OnlineStudent.ID:
                    return new OnlineStudent(name, evaluations);
                case OnsiteStudent.ID:
                    return new OnsiteStudent(name, evaluations);
                case RemoteStudent.ID:
                    return new RemoteStudent(name, evaluations);
            }

            throw new NotImplementedException("Invalid ID");
        }
    }
}
