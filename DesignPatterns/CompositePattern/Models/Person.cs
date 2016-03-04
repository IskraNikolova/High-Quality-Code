namespace CompositePattern.Models
{
    using System;

    public class Person : PersonComponent
    {
        public Person(string name) 
            : base(name)
        {
        }

        public override void Add(PersonComponent person)
        {
            Console.WriteLine("Cannot add to a person.");
        }

        public override void Remove(PersonComponent person)
        {
            Console.WriteLine("Cannot remove to a person.");
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new string('-', depth)} {this.name}");
        }
    }
}