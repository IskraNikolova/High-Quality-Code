namespace CompositePattern.Models
{
    public abstract class PersonComponent
    {
        protected string name;

        protected PersonComponent(string name)
        {
            this.name = name;
        }

        public abstract void Add(PersonComponent person);

        public abstract void Remove(PersonComponent person);

        public abstract void Display(int depth);
    }
}