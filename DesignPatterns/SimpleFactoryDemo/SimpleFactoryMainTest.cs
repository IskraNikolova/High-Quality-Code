using System;
using System.Collections.Generic;
using System.Linq;
using SimpleFactoryDemo.Factory;
using SimpleFactoryDemo.Interfaces;

namespace SimpleFactoryDemo
{
    public class SimpleFactoryMainTest
    {
        public static void Main()
        {
            string[] data = new string[3];
            data[0] = "2";
            data[1] = "Mariq Hristova";
            data[2] = "6 6 5";

            int id = int.Parse(data[0]);
            string name = data[1];
            List<int> evalutions = data[2].Split().Select(int.Parse).ToList();

            IStudent student = SimpleFactory.Create(id, name, evalutions);

            Console.WriteLine(student);
        }
    }
}
