namespace Abstraction.Models
{
    using System;

    public abstract class Figure : IShape
    {
        private double width;
        private double height;

        protected Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        protected Figure(double width)
        {
            this.Width = width;
        }

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("This value cannot be negative or null.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("This value cannot be negative or null.");
                }

                this.height = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
 
        public override string ToString()
        {
            return $"I am a {GetType().Name}. My perimeter is {this.CalculatePerimeter()}cm. " +
                   $"My surface is {this.CalculateArea()}cm.";
        }
    }
}
