using System;
using System.Collections.Generic;
using System.Linq;
using SimpleFactoryDemo.Core;
namespace SimpleFactoryDemo
{
    using SimpleFactoryDemo.Factory;
    using SimpleFactoryDemo.Interfaces;

    public class SimpleFactoryMainTest
    {
        public static void Main()
        {
            IFactory factory = new SimpleFactory();
            var controller = new UnitController(factory);
            IStudent student = controller.GetAllStudents(new []{"Online", "Iskra Radeva", "5.0 6 6"});

            Console.WriteLine($"Name {student.Name}");      
        }
    }
}
